using System;
using System.Collections.Generic;
using System.Linq;
using Kursovik.Model;

namespace Kursovik.Presenter
{
    public class Parser
    {
        private enum ParserState
        {
            Start, IdRem, FString, FSymbol, EndFString, Format, OpenArg,
            Scientific, ExpNumRem, End, Error
        }

        private ParserState currentState;
        private List<Lexem> lexems;
        private int position;
        public List<ErrorPair> stateLog;

        public Parser(List<Lexem> lexems)
        {
            this.lexems = lexems;
            this.position = 0;
            this.currentState = ParserState.Start;
            this.stateLog = new List<ErrorPair>();
        }

        public void Parse()
        {
            bool hasErrors = false;
            bool rowHasEnded = false;
            int globalEndPos = 0;
            while (position < lexems.Count)
            {
                Lexem currentLexem = lexems[position];

                switch (currentState)
                {
                    case ParserState.Start:
                        rowHasEnded = false;
                        if (currentLexem.lexemCode == 1){
                            currentState = ParserState.IdRem;
                        }
                        else if (currentLexem.lexemCode == 19)
                        {
                            if (char.IsDigit(currentLexem.lexemContaintment[0]))
                            {
                                ErrorState(currentLexem, currentLexem.lexemStartPosition, currentLexem.lexemStartPosition, "Идентификатор не может начинаться с цифры!");
                            }
                            for (int i = 0; i<currentLexem.lexemContaintment.Length; i++)
                            {
                                if (((currentLexem.lexemContaintment[i] >= 'а') && (currentLexem.lexemContaintment[i] <= 'я'))||((currentLexem.lexemContaintment[i] >= 'А') &&(currentLexem.lexemContaintment[i] <= 'Я')))
                                {
                                    int errPosStart = currentLexem.lexemStartPosition + i;
                                    int errPosEnd = errPosStart;
                                    while ((((currentLexem.lexemContaintment[i] >= 'а') && (currentLexem.lexemContaintment[i] <= 'я')) || ((currentLexem.lexemContaintment[i] >= 'А') && (currentLexem.lexemContaintment[i] <= 'Я'))) && i < currentLexem.lexemContaintment.Length-1 && errPosEnd < currentLexem.lexemContaintment.Length-1)
                                    {
                                        i++;
                                        errPosEnd++;
                                    }
                                    ErrorState(currentLexem, errPosStart, errPosEnd, "Идентификатор не может содержать символы кириллицы!");
                                }
                                else if (!char.IsLetterOrDigit(currentLexem.lexemContaintment[i]))
                                {
                                    ErrorState(currentLexem, currentLexem.lexemStartPosition, currentLexem.lexemEndPosition, $"Недопустимый символ: '{currentLexem.lexemContaintment[i]}'!");
                                }
                            }
                            currentState = ParserState.IdRem;
                        }
                        else if (position >= lexems.Count())
                        {
                            ErrorState(null, "Ожидался идентификатор, но лексемы не найдено.");
                            hasErrors = true;
                        }
                        else if (position < lexems.Count())
                        {
                            int count = 0;
                            bool fullExit = false;
                            bool tempExit = false;
                            int errPosStart = currentLexem.lexemStartPosition;
                            int tempPos = position;
                            Lexem currentTempLexem = lexems[tempPos];
                            while (currentTempLexem.lexemCode != 4 && tempPos <= lexems.Count())
                            {
                                if (currentTempLexem.lexemCode == 18)
                                {
                                    if (count == 0)
                                    {
                                        fullExit = true;
                                        ErrorState(currentLexem, errPosStart, currentLexem.lexemEndPosition, "Ожидался идентификатор.");
                                        currentState = ParserState.End;
                                        break;
                                    }
                                    fullExit = true;
                                    ErrorState(currentLexem, errPosStart, currentLexem.lexemEndPosition, "Ожидался идентификатор.");
                                    currentState = ParserState.IdRem;
                                    break;
                                }
                                count++;
                                tempPos++;
                                if (tempPos < lexems.Count())
                                {
                                    currentTempLexem = lexems[tempPos];
                                }
                                else
                                {
                                    tempExit = true;
                                    ErrorState(currentLexem, errPosStart, currentLexem.lexemEndPosition, "Ожидался идентификатор.");
                                    currentState = ParserState.End;
                                    break;
                                }
                            }
                            if (tempExit)
                            {
                                break;
                            }
                            if (fullExit)
                            {
                                continue;
                            }
                            position = tempPos;
                            currentState = ParserState.IdRem;
                            ErrorState(currentLexem, errPosStart, currentTempLexem.lexemStartPosition, "Ожидался идентификатор.");
                            continue;
                        }
                        else
                        {
                            ErrorState(currentLexem, currentLexem.lexemStartPosition, currentLexem.lexemEndPosition, $"Ожидался идентификатор, но была найдена лексема с типом {currentLexem.lexemType} (Лексема {currentLexem.lexemContaintment}).");
                            hasErrors = true;
                            currentState = ParserState.IdRem;
                        }
                        break;

                    case ParserState.IdRem:
                        if (currentLexem.lexemCode == 4)
                            currentState = ParserState.FSymbol;
                        else if (position >= lexems.Count())
                        {
                            ErrorState(null, "Ожидался символ '=', но лексемы не найдено.");
                        }
                        else if (position < lexems.Count())
                        {
                            int count = 0;
                            bool fullExit = false;
                            bool tempExit = false;
                            int errPosStart = currentLexem.lexemStartPosition;
                            int tempPos = position;
                            Lexem currentTempLexem = lexems[tempPos];
                            while (currentTempLexem.lexemCode != 6 && tempPos <= lexems.Count())
                            {
                                if (currentTempLexem.lexemCode == 18)
                                {
                                    if (count == 0)
                                    {
                                        fullExit = true;
                                        ErrorState(currentLexem, errPosStart, currentLexem.lexemEndPosition, "Ожидался символ '='.");
                                        currentState = ParserState.End;
                                        break;
                                    }
                                    fullExit = true;
                                    ErrorState(currentLexem, errPosStart, currentLexem.lexemEndPosition, "Ожидался символ '='.");
                                    currentState = ParserState.FSymbol;
                                    break;
                                }
                                count++;
                                tempPos++;
                                if (tempPos < lexems.Count())
                                {
                                    currentTempLexem = lexems[tempPos];
                                }
                                else
                                {
                                    tempExit = true;
                                    ErrorState(currentLexem, errPosStart, currentLexem.lexemEndPosition, "Ожидался символ '='.");
                                    currentState = ParserState.End;
                                    break;
                                }
                            }
                            if (tempExit)
                            {
                                break;
                            }
                            if (fullExit)
                            {
                                continue;
                            }
                            position = tempPos;
                            currentState = ParserState.FSymbol;
                            ErrorState(currentLexem, errPosStart, currentTempLexem.lexemStartPosition, "Ожидался символ '='.");
                            continue;
                        }
                        else
                        {
                            ErrorState(currentLexem, currentLexem.lexemStartPosition, currentLexem.lexemEndPosition, "Ожидался символ '='.");
                            hasErrors = true;
                            currentState = ParserState.FSymbol;
                        }
                        break;

                    case ParserState.FSymbol:
                        if (currentLexem.lexemCode == 6)
                            currentState = ParserState.EndFString;
                        else if (position >= lexems.Count())
                        {
                            ErrorState(null, "Ожидался форматный спецификатор '\"{:f}\"', но лексемы не найдено.");
                        }
                        else if (currentLexem.lexemCode == 19)
                        {
                            ErrorState(currentLexem, currentLexem.lexemStartPosition, currentLexem.lexemEndPosition, "Ожидался форматный спецификатор '\"{:f}\"'!");
                        }
                        else if (position < lexems.Count())
                        {
                            int count = 0;
                            bool fullExit = false;
                            bool tempExit = false;
                            int errPosStart = currentLexem.lexemStartPosition;
                            int tempPos = position;
                            Lexem currentTempLexem = lexems[tempPos];
                            while (currentTempLexem.lexemCode != 9 && tempPos <= lexems.Count())
                            {
                                if (currentTempLexem.lexemCode == 18)
                                {
                                    if (count == 0)
                                    {
                                        fullExit = true;
                                        ErrorState(currentLexem, errPosStart, currentLexem.lexemEndPosition, "Ожидался форматный спецификатор '\"{:f}\"'.");
                                        currentState = ParserState.End;
                                        break;
                                    }
                                    fullExit = true;
                                    ErrorState(currentLexem, errPosStart, currentLexem.lexemEndPosition, "Ожидался форматный спецификатор '\"{:f}\"'.");
                                    currentState = ParserState.EndFString;
                                    break;
                                }
                                count++;
                                tempPos++;
                                if (tempPos < lexems.Count())
                                {
                                    currentTempLexem = lexems[tempPos];
                                }
                                else
                                {
                                    tempExit = true;
                                    ErrorState(currentLexem, errPosStart, currentLexem.lexemEndPosition, "Ожидался форматный спецификатор '\"{:f}\"'.");
                                    currentState = ParserState.End;
                                    break;
                                }
                            }
                            if (tempExit)
                            {
                                break;
                            }
                            if (fullExit)
                            {
                                continue;
                            }
                            position = tempPos;
                            currentState = ParserState.EndFString;
                            ErrorState(currentLexem, errPosStart, currentTempLexem.lexemStartPosition, "Ожидался форматный спецификатор '\"{:f}\"'.");
                            continue;
                        }
                        else
                        {
                            ErrorState(currentLexem, currentLexem.lexemStartPosition, currentLexem.lexemEndPosition, "Ожидался форматный спецификатор '\"{:f}\"'.");
                            hasErrors = true;
                            currentState = ParserState.EndFString;
                        }
                        break;

                    case ParserState.EndFString:
                        if (currentLexem.lexemCode == 9)
                            currentState = ParserState.Format;
                        else if (position >= lexems.Count())
                        {
                            ErrorState(null, "Ожидалась точка ('.'), но лексемы не найдено.");
                        }
                        else if (position < lexems.Count())
                        {
                            int count = 0;
                            bool fullExit = false;
                            bool tempExit = false;
                            int errPosStart = currentLexem.lexemStartPosition;
                            int tempPos = position;
                            Lexem currentTempLexem = lexems[tempPos];
                            while (currentTempLexem.lexemCode != 2 && tempPos <= lexems.Count()) {
                                if (currentTempLexem.lexemCode == 18)
                                {
                                    if (count == 0)
                                    {
                                        fullExit = true;
                                        ErrorState(currentLexem, errPosStart, currentLexem.lexemEndPosition, "Ожидалась точка ('.').");
                                        currentState = ParserState.End;
                                        break;
                                    }
                                    fullExit = true;
                                    ErrorState(currentLexem, errPosStart, currentLexem.lexemEndPosition, "Ожидалась точка ('.').");
                                    currentState = ParserState.Format;
                                    break;
                                }
                                count++;
                                tempPos++;
                                if(tempPos < lexems.Count())
                                {
                                    currentTempLexem = lexems[tempPos];
                                }
                                else
                                {
                                    tempExit = true;
                                    ErrorState(currentLexem, errPosStart, currentLexem.lexemEndPosition, "Ожидалась точка ('.').");
                                    currentState = ParserState.End;
                                    break;
                                }
                            }
                            if (tempExit)
                            {
                                break;
                            }
                            if (fullExit)
                            {
                                continue;
                            }
                            position = tempPos;
                            currentState = ParserState.Format;
                            ErrorState(currentLexem, errPosStart, currentTempLexem.lexemStartPosition, "Ожидалась точка ('.').");
                            continue;
                        }
                        else
                        {
                            ErrorState(currentLexem, currentLexem.lexemStartPosition, currentLexem.lexemEndPosition, "Ожидалась точка ('.').");
                            hasErrors = true;
                            currentState = ParserState.Format;
                        }
                        break;

                    case ParserState.Format:
                        if (currentLexem.lexemCode == 2)
                            currentState = ParserState.OpenArg;
                        else if (currentLexem.lexemCode == 19)
                        {
                            for (int i = 0; i < currentLexem.lexemContaintment.Length-1; i++)
                            {
                                if (((currentLexem.lexemContaintment[i] >= 'а') && (currentLexem.lexemContaintment[i] <= 'я')) || ((currentLexem.lexemContaintment[i] >= 'А') && (currentLexem.lexemContaintment[i] <= 'Я')))
                                {
                                    int errPosStart = currentLexem.lexemStartPosition + i;
                                    int errPosEnd = errPosStart;
                                    while ((((currentLexem.lexemContaintment[i] >= 'а') && (currentLexem.lexemContaintment[i] <= 'я')) || ((currentLexem.lexemContaintment[i] >= 'А') && (currentLexem.lexemContaintment[i] <= 'Я'))) && i < currentLexem.lexemContaintment.Length - 1 && errPosEnd < currentLexem.lexemContaintment.Length - 1)
                                    {
                                        i++;
                                        errPosEnd++;
                                    }
                                    ErrorState(currentLexem, errPosStart, errPosEnd, "Ключевое слово не может содержать символы кириллицы!");
                                }
                                else if (!char.IsLetterOrDigit(currentLexem.lexemContaintment[i]))
                                {
                                    ErrorState(currentLexem, currentLexem.lexemStartPosition+i, currentLexem.lexemEndPosition-i, "Недопустимый символ!");
                                }
                            }
                            currentState = ParserState.OpenArg;
                        }
                        else if (position >= lexems.Count())
                        {
                            ErrorState(null, "Ожидалось ключевое слово 'format', но лексемы не найдено.");
                        }
                        else if (position < lexems.Count())
                        {
                            int count = 0;
                            bool fullExit = false;
                            bool tempExit = false;
                            int errPosStart = currentLexem.lexemStartPosition;
                            int tempPos = position;
                            Lexem currentTempLexem = lexems[tempPos];
                            while (currentTempLexem.lexemCode != 16 && tempPos < lexems.Count())
                            {
                                if (currentTempLexem.lexemCode == 18)
                                {
                                    if (count == 0)
                                    {
                                        fullExit = true;
                                        ErrorState(currentLexem, errPosStart, currentLexem.lexemEndPosition, "Ожидалось ключевое слово 'format'.");
                                        currentState = ParserState.End;
                                        break;
                                    }
                                    fullExit = true;
                                    ErrorState(currentLexem, errPosStart, currentLexem.lexemEndPosition, "Ожидалось ключевое слово 'format'.");
                                    currentState = ParserState.OpenArg;
                                    break;
                                }
                                count++;
                                tempPos++;
                                if (tempPos < lexems.Count())
                                {
                                    currentTempLexem = lexems[tempPos];
                                }
                                else
                                {
                                    tempExit = true;
                                    ErrorState(currentLexem, errPosStart, currentLexem.lexemEndPosition, "Ожидалось ключевое слово 'format'.");
                                    currentState = ParserState.End;
                                    break;
                                }
                            }
                            if (tempExit)
                            {
                                break;
                            }
                            if (fullExit)
                            {
                                continue;
                            }
                            position = tempPos;
                            currentState = ParserState.OpenArg;
                            ErrorState(currentLexem, errPosStart, currentTempLexem.lexemStartPosition, "Ожидалось ключевое слово 'format'.");
                            continue;
                        }
                        else
                        {
                            ErrorState(currentLexem, currentLexem.lexemStartPosition, currentLexem.lexemEndPosition, "Ожидалось ключевое слово 'format'.");
                            hasErrors = true;
                            currentState = ParserState.OpenArg;
                        }
                        break;

                    case ParserState.OpenArg:
                        if (currentLexem.lexemCode == 16)
                            currentState = ParserState.Scientific;
                        else if (position >= lexems.Count())
                        {
                            ErrorState(null, "Ожидалась открывающая скобка ('('), но лексемы не найдено.");
                        }
                        else if (position < lexems.Count())
                        {
                            int count = 0;
                            bool fullExit = false;
                            bool tempExit = false;
                            int errPosStart = currentLexem.lexemStartPosition;
                            int tempPos = position;
                            Lexem currentTempLexem = lexems[tempPos];
                            while (currentTempLexem.lexemCode != 10 && currentTempLexem.lexemCode != 11 && currentTempLexem.lexemCode != 14 && currentTempLexem.lexemCode != 15 && tempPos < lexems.Count())
                            {
                                if (currentTempLexem.lexemCode == 18)
                                {
                                    if (count == 0)
                                    {
                                        fullExit = true;
                                        ErrorState(currentLexem, errPosStart, currentLexem.lexemEndPosition, "Ожидалась открывающая скобка '('.");
                                        currentState = ParserState.End;
                                        break;
                                    }
                                    fullExit = true;
                                    ErrorState(currentLexem, errPosStart, currentLexem.lexemEndPosition, "Ожидалась открывающая скобка '('.");
                                    currentState = ParserState.Scientific;
                                    break;
                                }
                                count++;
                                tempPos++;
                                if (tempPos < lexems.Count())
                                {
                                    currentTempLexem = lexems[tempPos];
                                }
                                else
                                {
                                    tempExit = true;
                                    ErrorState(currentLexem, errPosStart, currentLexem.lexemEndPosition, "Ожидалась открывающая скобка '('.");
                                    currentState = ParserState.End;
                                    break;
                                }
                            }
                            if (tempExit)
                            {
                                break;
                            }
                            if (fullExit)
                            {
                                continue;
                            }
                            position = tempPos;
                            currentState = ParserState.Scientific;
                            ErrorState(currentLexem, errPosStart, currentTempLexem.lexemStartPosition, "Ожидалась открывающая скобка '('.");
                            continue;
                        }
                        else
                        {
                            ErrorState(currentLexem, currentLexem.lexemStartPosition, currentLexem.lexemEndPosition, "Ожидалась открывающая скобка '('.");
                            hasErrors = true;
                            currentState = ParserState.Scientific;
                        }
                        break;

                    case ParserState.Scientific:
                        if (currentLexem.lexemCode == 10 || currentLexem.lexemCode == 11)
                        {
                            currentState = ParserState.ExpNumRem; break;
                        }
                        else if (currentLexem.lexemCode == 14 || currentLexem.lexemCode == 15)
                        {
                            currentState = ParserState.ExpNumRem; break;
                        }
                        else if (currentLexem.lexemCode == 7 || currentLexem.lexemCode == 8)
                        {
                            position++;
                            continue;
                        }
                        else if (currentLexem.lexemCode == 19)
                        {
                            string num = currentLexem.lexemContaintment.ToString(); // Получаем строковое представление числа
                            bool hasDot = false;
                            bool hasExp = false;
                            bool hasFractionPart = false;
                            bool hasExpNumber = false;
                            bool hasPlus = false;
                            int dotCount = 0;
                            int expIndex = -1;

                            // Проверка, начинается ли число с цифры
                            if (!char.IsDigit(num[0]))
                            {
                                ErrorState(currentLexem, currentLexem.lexemStartPosition, currentLexem.lexemStartPosition, "Аргумент должен быть числом!");
                            }

                            for (int i = 0; i < num.Length; i++)
                            {
                                char c = num[i];

                                if (c == '.')
                                {
                                    dotCount++;
                                    if (dotCount > 1)
                                    {
                                        ErrorState(currentLexem, currentLexem.lexemStartPosition, currentLexem.lexemEndPosition, "Некорректная запись числа! Лишняя точка.");
                                    }
                                    hasDot = true;
                                    if (i == num.Length - 1)
                                    {
                                        ErrorState(currentLexem, currentLexem.lexemStartPosition, currentLexem.lexemEndPosition, "Отсутствует вещественная часть числа после точки.");
                                    }
                                }
                                else if (char.IsDigit(c))
                                {
                                    if (hasDot && !hasPlus)
                                        hasFractionPart = true;

                                    if (hasExp && hasPlus)
                                        hasExpNumber = true;
                                }
                                else if (c == 'e' || c == 'E')
                                {
                                    if (hasExp)
                                    {
                                        ErrorState(currentLexem, currentLexem.lexemStartPosition, currentLexem.lexemEndPosition, "Некорректная запись числа! Лишний символ экспоненты.");
                                        hasErrors = true;
                                    }
                                    hasExp = true;
                                    expIndex = i;
                                    if (i == 0)
                                    {
                                        ErrorState(currentLexem, currentLexem.lexemStartPosition, currentLexem.lexemEndPosition, "Некорректная запись числа! Символ экспоненты без числа перед ним.");
                                    }

                                    if (i == num.Length)
                                    {
                                        ErrorState(currentLexem, currentLexem.lexemStartPosition, currentLexem.lexemEndPosition, "Отсутствует показатель экспоненты.");
                                    }
                                }
                                else if (i == expIndex + 1 && (c == '+' || c == '-'))
                                {
                                    hasPlus = true;
                                    if (i == num.Length - 1)
                                    {
                                        ErrorState(currentLexem, currentLexem.lexemStartPosition, currentLexem.lexemEndPosition, "Отсутствует показатель экспоненты после знака.");
                                    }
                                }
                                else
                                {
                                    ErrorState(currentLexem, currentLexem.lexemStartPosition, currentLexem.lexemEndPosition, $"Некорректный символ в числе: {c}");
                                }
                            }
                            if (hasDot && !hasFractionPart)
                            {
                                ErrorState(currentLexem, currentLexem.lexemStartPosition, currentLexem.lexemEndPosition, "Некорректная запись числа! Отсутствует вещественная часть после точки.");
                            }

                            currentState = ParserState.ExpNumRem;
                            break;
                        }
                        else if (position >= lexems.Count())
                        {
                            ErrorState(null, "Ожидалось число в экспоненциальной записи (например, 3.14e+4), но лексемы не найдено.");
                        }
                        else if (position < lexems.Count())
                        {
                            int count = 0;
                            bool fullExit = false;
                            bool tempExit = false;
                            int errPosStart = currentLexem.lexemStartPosition;
                            int tempPos = position;
                            Lexem currentTempLexem = lexems[tempPos];
                            while (currentTempLexem.lexemCode != 17 && tempPos < lexems.Count())
                            {
                                if (currentTempLexem.lexemCode == 18)
                                {
                                    if (count == 0)
                                    {
                                        fullExit = true;
                                        ErrorState(currentLexem, errPosStart, currentLexem.lexemEndPosition, "Ожидалось число в экспоненциальной записи (например, 3.14e+4).");
                                        currentState = ParserState.End;
                                        break;
                                    }
                                    fullExit = true;
                                    ErrorState(currentLexem, errPosStart, currentLexem.lexemEndPosition, "Ожидалось число в экспоненциальной записи (например, 3.14e+4).");
                                    currentState = ParserState.ExpNumRem;
                                    break;
                                }
                                count++;
                                tempPos++;
                                if (tempPos < lexems.Count())
                                {
                                    currentTempLexem = lexems[tempPos];
                                }
                                else
                                {
                                    tempExit = true;
                                    ErrorState(currentLexem, errPosStart, currentLexem.lexemEndPosition, "Ожидалось число в экспоненциальной записи (например, 3.14e+4).");
                                    currentState = ParserState.End;
                                    break;
                                }
                            }
                            if (tempExit)
                            {
                                break;
                            }
                            if (fullExit)
                            {
                                continue;
                            }
                            position = tempPos;
                            currentState = ParserState.ExpNumRem;
                            ErrorState(currentLexem, errPosStart, currentTempLexem.lexemStartPosition, "Ожидалось число в экспоненциальной записи (например, 3.14e+4).");
                            continue;
                        }
                        else
                        {
                            ErrorState(currentLexem, currentLexem.lexemStartPosition, currentLexem.lexemEndPosition, "Ожидалось число в экспоненциальной записи (например, 3.14e+4).");
                            hasErrors = true;
                            currentState = ParserState.ExpNumRem;
                        }
                        break;
                    case ParserState.ExpNumRem:
                        if (currentLexem.lexemCode == 17)
                        {
                            globalEndPos = currentLexem.lexemEndPosition;
                            currentState = ParserState.End;
                        } 
                        else if (position >= lexems.Count())
                        {
                            ErrorState(null, "Ожидалась закрывающая скобка (')'), но лексемы не найдено.");
                        }
                        else if (position < lexems.Count())
                        {
                            int count = 0;
                            bool fullExit = false;
                            bool tempExit = false;
                            int errPosStart = currentLexem.lexemStartPosition;
                            int tempPos = position;
                            Lexem currentTempLexem = lexems[tempPos];
                            while (tempPos <= lexems.Count())
                            {
                                if (currentTempLexem.lexemCode == 18)
                                {
                                    if (count == 0)
                                    {
                                        fullExit = true;
                                        ErrorState(currentLexem, errPosStart, currentLexem.lexemEndPosition, "Ожидалась закрывающая скобка ')'.");
                                        currentState = ParserState.End;
                                        break;
                                    }
                                    fullExit = true;
                                    ErrorState(currentLexem, errPosStart, currentLexem.lexemEndPosition, "Ожидалась закрывающая скобка ')'.");
                                    currentState = ParserState.End;
                                    break;
                                }
                                count++;
                                tempPos++;
                                if (tempPos < lexems.Count())
                                {
                                    currentTempLexem = lexems[tempPos];
                                }
                                else
                                {
                                    tempExit = true;
                                    ErrorState(currentLexem, errPosStart, currentLexem.lexemEndPosition, "Ожидалась закрывающая скобка ')'.");
                                    currentState = ParserState.End;
                                    break;
                                }
                            }
                            if (tempExit)
                            {
                                break;
                            }
                            if (fullExit)
                            {
                                continue;
                            }
                            position = tempPos;
                            currentState = ParserState.End;
                            ErrorState(currentLexem, errPosStart, currentTempLexem.lexemStartPosition, "Ожидалась закрывающая скобка ')'.");
                            continue;
                        }
                        else
                        {
                            ErrorState(currentLexem, currentLexem.lexemStartPosition, currentLexem.lexemEndPosition, "Ожидалась закрывающая скобка ')'.");
                            hasErrors = true;
                            currentState = ParserState.End;
                        }
                        break;

                    case ParserState.End:
                        if (currentLexem.lexemCode == 18 && !hasErrors && position >= lexems.Count()-1) {
                            rowHasEnded = true;
                            return;
                        } 
                        else if (currentLexem.lexemCode == 18 && hasErrors)
                        {
                            break;
                        }
                        else if (currentLexem.lexemCode == 18 && position < lexems.Count())
                        {
                            currentState = ParserState.Start;
                        }
                        else if (position <= lexems.Count())
                        {
                            bool fullExit = false;
                            int errPosStart = currentLexem.lexemStartPosition;
                            int tempPos = position;
                            Lexem currentTempLexem = lexems[tempPos];
                            while (tempPos < lexems.Count())
                            {
                                if (currentTempLexem.lexemCode == 18)
                                {
                                    fullExit = true;
                                    ErrorState(currentLexem, errPosStart, currentLexem.lexemEndPosition, "Ожидался символ ';'.");
                                    currentState = ParserState.Start;
                                    break;
                                }
                                tempPos++;
                                if (tempPos == lexems.Count())
                                {
                                    ErrorState(null, errPosStart, currentTempLexem.lexemEndPosition, "Ожидался символ ';'.");
                                    return;
                                }
                                currentTempLexem = lexems[tempPos];
                            }
                            if (fullExit)
                            {
                                continue;
                            }
                            position = tempPos;
                            currentState = ParserState.Start;
                            ErrorState(currentLexem, errPosStart, position, "Ожидался символ ';'.");
                            continue;
                        }
                        else
                        {
                            ErrorState(currentLexem, currentLexem.lexemStartPosition, currentLexem.lexemEndPosition, "Ожидался символ ';'.");
                            hasErrors = true;
                        }
                        break;
                    case ParserState.Error:
                        break;
                }
                position++;
            }
            if (!rowHasEnded)
            {
                ErrorState(null, globalEndPos, globalEndPos, "Ожидался символ ';'.");
            }
            return;
        }
        private bool ErrorState(Lexem lexem, string message)
        {
            stateLog.Add(new ErrorPair(message, lexem));
            return false;
        }
        private void ErrorState(Lexem lexem, int posStart, int posEnd, string message)
        {
            stateLog.Add(new ErrorPair(message, lexem, posStart, posEnd));
        }

        public void PrintLog()
        {
            foreach (var entry in stateLog)
            {
                Console.WriteLine(entry);
            }
        }
    }

    public class ErrorPair
    {
        public Lexem errorLexem;
        public string errorMessage;
        public int posStart;
        public int posEnd;
        public ErrorPair(string message, Lexem lexem)
        {
            if (lexem != null)
            {
                errorLexem = lexem;
            }
            errorMessage = message;
        }
        public ErrorPair(string message, Lexem lexem, int start, int end)
        {
            if (lexem != null)
            {
                errorLexem = lexem;
            }
            errorLexem = lexem;
            errorMessage = message;
            posStart = start;
            posEnd = end;
        }
    }
}
