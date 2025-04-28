using Kursovik.Model;
using Kursovik.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Kursovik.Presenter
{
    //Сам класс сканера :D
    public class Lexer
    {
        //Переменные, необходимые для работы сканера
        private string text;
        private int position;
        private List<Lexem> lexemsList;
        private ResourceManager _res;

        //Конструктор
        public Lexer(string textToScan, ResourceManager res)
        {
            _res = res ?? throw new ArgumentNullException("Не найден файл локализации для выбранного языка!");
            text = textToScan;
            position = 0;
            lexemsList = new List<Lexem>();
        }

        //Метод сканирования
        public List<Lexem> Scan()
        {
            while (position < text.Length)
            { 
                char currentChar = text[position];

                if ((currentChar >= 'a') && (currentChar <= 'z') || ((currentChar >= 'A') && (currentChar <= 'Z') || ((currentChar >= '0') && (currentChar <= '9')) || currentChar == '-' || currentChar == '+') || ((currentChar >= 'а') && (currentChar <= 'я')) || ((currentChar >= 'А') && (currentChar <= 'Я')))
                {
                    ProcessIdentifierOrNumber();
                }
                else
                {
                    if (ProcessSymbol()) break;
                }
            }
            List<Lexem> optimized = new List<Lexem>();
            int i = 0;
            while (i < lexemsList.Count)
            {
                if (lexemsList[i].lexemCode == 19)
                {
                    int start = lexemsList[i].lexemStartPosition;
                    int end = lexemsList[i].lexemEndPosition;
                    string value = lexemsList[i].lexemContaintment;

                    int j = i + 1;
                    while (j < lexemsList.Count && lexemsList[j].lexemCode == 19)
                    {
                        value += lexemsList[j].lexemContaintment;
                        end = lexemsList[j].lexemEndPosition;
                        j++;
                    }

                    optimized.Add(new Lexem(19, value, start, end, _res));

                    i = j;
                }
                else
                {
                    optimized.Add(lexemsList[i]);
                    i++;
                }
            }
            return optimized;
        }

        //Обработка численно-буквенных лексем
        private void ProcessIdentifierOrNumber()
        {
            int start = position;
            bool isDouble = false; 
            bool isScientific = false;
            bool startsWithDigit = false;
            if (text[start] == '+' || text[start] == '-')
            {
                startsWithDigit = char.IsDigit(text[start+1]);
            }
            else
            {
                startsWithDigit = char.IsDigit(text[start]);
            }
            bool hasLetter = false;
            bool hasDot = false;
            bool isAcceptable = true;
            bool isInt = true;
            bool isError = false;

            while (position < text.Length && ((char.IsLetterOrDigit(text[position]) ||
                text[position] == '.' || text[position] == '+' || text[position] == '-') ||
                ((text[position] != '"') && (text[position] != '=') && (text[position] != '(') && (text[position] != ')') && (text[position] != ';'))))
            {
                if (text[position] == '.')
                {
                    if (!hasDot && !hasLetter)
                    {
                        hasDot = true;
                        isDouble = true;
                        isInt = false;
                    }
                    else if (!hasLetter)
                    {
                        isAcceptable = false;
                        isDouble = false;
                        isInt = false;
                    }
                    else
                    {
                        string lexeme_break_end = text.Substring(start, (position) - start);
                        lexemsList.Add(new Lexem(1,lexeme_break_end,start,position, _res));
                        return;
                    }
                }
                else if (text[position] == '+' || text[position] == '-')
                {
                    position++;
                    continue;
                }
                else if (((text[position] >= 'a') && (text[position] <= 'z') || ((text[position] >= 'A') && (text[position] <= 'Z')) && !(((text[position] >= 'а') && (text[position] <= 'я')) || ((text[position] >= 'А') && (text[position] <= 'Я')))))
                {
                    if ((text[position] == 'e' || text[position] == 'E') && (text[position-1] >= '0') && (text[position-1] <= '9'))
                    {
                        if (!isScientific)
                        {
                            isScientific = true;
                            isInt = false;
                        }
                        else
                        {
                            isScientific = false;
                            isDouble = false;
                            hasLetter = true;
                            isInt = false;
                        }
                    }
                    else
                    {
                        isDouble = false;
                        isScientific = false;
                        hasLetter = true;
                        isInt = false;
                    }
                }
                else if (char.IsDigit(text[position]))
                {
                    position++;
                    continue;
                }
                else if (char.IsWhiteSpace(text[position]))
                {
                    break;
                }
                else
                {
                    isAcceptable = false;
                }
                position++;
            }
            
            string lexeme = text.Substring(start, position - start);
            int code;
            if (isError)
            {
                lexemsList.Add(new Lexem(19, lexeme, start, position - start, _res));
                return;
            }
            if (isScientific && isAcceptable && startsWithDigit)
            {
                if (lexeme.Contains('-') | lexeme.Contains('+'))
                {
                    if (isDouble)
                    {
                        code = lexeme.Contains('-') ? 14 : 15;
                        lexemsList.Add(new Lexem(code, lexeme, start, position, _res));
                        return;
                    }
                    else
                    {
                        code = lexeme.Contains('-') ? 10 : 11;
                        lexemsList.Add(new Lexem(code, lexeme, start, position, _res));
                        return;
                    }
                }
                else
                {
                    lexemsList.Add(new Lexem(19, lexeme, start, position, _res));
                    return;
                }
            }
            else if (isInt && isAcceptable && startsWithDigit)
            {
                lexemsList.Add(new Lexem(12, lexeme,start, position, _res));
            }
            else if (isDouble && isAcceptable && startsWithDigit)
            {
                lexemsList.Add(new Lexem(13, lexeme, start, position, _res));
                return;
            }
            else if (startsWithDigit && !isAcceptable)
            {
                lexemsList.Add(new Lexem(19, lexeme, start, position, _res));
                return;
            }
            else if (hasLetter && !hasDot && isAcceptable && !startsWithDigit)
            {
                if (lexeme == "format")
                {
                    lexemsList.Add(new Lexem(2,lexeme,start, position, _res));
                    return;
                }
                else
                {
                    lexemsList.Add(new Lexem(1, lexeme,start, position, _res));
                    return;
                }
            }
            else
            {
                lexemsList.Add(new Lexem(19, lexeme, start, position, _res));
            }
        }

        //Обработка символа
        private bool ProcessSymbol()
        {
            int start = position;
            char currentChar = text[position++];
            int code;
            switch (currentChar)
            {
                case '=': code = 4; break;
                case '"': ProcessString(); return false;
                case '-': code = 7; break;
                case '+': code = 8; break;
                case '.': code = 9; break;
                case '(': code = 16; break;
                case ')': code = 17; break;
                case ';': code = 18; 
                    if (position >= text.Length)
                    {
                        lexemsList.Add(new Lexem(code, currentChar.ToString(), start, position, _res));
                        return true;
                    }
                    else
                    {
                        break;
                    }
                case ' ': return false;
                default: code = 19; break;
            }
            lexemsList.Add(new Lexem(code, currentChar.ToString(), start, position, _res));
            return false;
        }

        //Обработка строки
        private void ProcessString()
        {
            int start = position - 1;
            bool hasSecondQuote = false;
            StringBuilder sb = new StringBuilder();
            bool isFString = false;
            bool hasErr = false;

            while (position < text.Length)
            {
                char currentChar = text[position];
                if (text[position] == '"')
                {
                    position++;
                    hasSecondQuote = true;
                    break;
                }
                sb.Append(text[position]);
                if (text[position] == '{')
                {
                    while (position < text.Length)
                    {
                        position++;
                        currentChar = text[position];
                        if (text[position] == ':')
                        {
                            while (position < text.Length && text[position] != '\"')
                            {
                                position++;
                                if (text[position] == 'f')
                                {
                                    while (position < text.Length && text[position] != '\"')
                                    {
                                        position++;
                                        if (text[position] == '}')
                                        {
                                            while (position < text.Length && text[position] != '\"')
                                            {
                                                position++;
                                                if (text[position] == '"')
                                                {
                                                    hasSecondQuote = true; 
                                                    isFString = true;
                                                    break;
                                                }
                                                else if (position >= text.Length)
                                                {
                                                    string errLexeme = text.Substring(start, position - start);
                                                    lexemsList.Add(new Lexem(19, errLexeme, start, position, _res));
                                                }
                                                else if (text[position] == ' ')
                                                {
                                                    continue;
                                                }
                                                else
                                                {
                                                    isFString = false;
                                                    break;
                                                }
                                            }
                                            break;
                                        }
                                        else if (text[position] == ' ')
                                        {
                                            continue;
                                        }
                                        else
                                        {
                                            isFString = false;
                                            break;
                                        }
                                    }
                                    break;
                                }
                                else if (text[position] == ' ')
                                {
                                    continue;
                                }
                                else
                                {
                                    isFString = false;
                                    break;
                                }
                            }
                            break;
                        }
                        else if (text[position] == ' ')
                        {
                            continue;
                        }
                        else
                        {
                            isFString = false;
                            break;
                        }
                    }
                }
                else
                {
                    position++;
                }
            }
            if (!hasSecondQuote)
            {
                string errLexeme = text.Substring(start, position - start);
                lexemsList.Add(new Lexem(19, errLexeme, start, position, _res));
            }
            else
            {
                string lexeme = text.Substring(start, position - start);
                int code = isFString ? 6 : 5;
                lexemsList.Add(new Lexem(code, lexeme, start, position, _res));
            }
        }
    }
}
