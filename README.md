# Игры разума (C#)

[![hexlet-check](https://github.com/kicha3007-boop/c-sharp-project-431/actions/workflows/hexlet-check.yml/badge.svg)](https://github.com/kicha3007-boop/c-sharp-project-431/actions)

Погрузитесь в экосистему .NET, научитесь настраивать рабочее окружение. Освоите dotnet CLI — инструмент создания, сборки и запуска проектов, и CSharpier, форматтер кода. Поймёте, чем git отличается от GitHub, поработаете с внешними репозиториями. Получите опыт построения архитектуры полноценного приложения и написания чистого кода.

Учебный проект Хекслета: https://ru.hexlet.io/programs/c-sharp


## Стек

- C# / .NET 10, dotnet CLI
- CSharpier — форматтер и проверка стиля
- make

Пять консольных игр: чётность, калькулятор, НОД, арифметическая прогрессия, простое число. Каждая задаёт
три вопроса; неверный ответ завершает игру.

## Установка

Нужны .NET SDK 10 (`dotnet --version`) и make.

```bash
git clone https://github.com/kicha3007-boop/c-sharp-project-431.git
cd c-sharp-project-431
make setup      # зависимости, CSharpier (dotnet tool restore) и сборка в dist/
```

Без установленного .NET — в контейнере:

```bash
docker run --rm -it -v "$PWD:/src" -w /src mcr.microsoft.com/dotnet/sdk:10.0 \
  sh -c 'apt-get update -qq && apt-get install -y -qq make >/dev/null && make setup && make run-dist'
```

## Использование

```bash
make run-dist   # запуск собранного dist/App
make run        # сборка и запуск через dotnet run
make lint       # проверка стиля (CSharpier)
make lint-fix   # автоисправление стиля
```

Устройство: `src/App/Program.cs` — только меню; `Cli.cs` — приветствие (пункт 1); `Engine.cs` — общий
цикл из трёх раундов; `Games/*.cs` — по файлу на игру, каждая отдаёт описание и генератор раунда
(вопрос, правильный ответ).

### Пример: победа (Прогрессия)

```console
$ make run-dist
Please enter the game number and press Enter.
1 - Greet
2 - Even
3 - Calc
4 - GCD
5 - Progression
6 - Prime
0 - Exit
Your choice: 5

Welcome to the Brain Games!
May I have your name? Bob
Hello, Bob!
What number is missing in the progression?
Question: 5 7 9 11 13 .. 17 19 21 23
Your answer: 15
Correct!
Question: 2 5 8 .. 14 17 20 23 26 29
Your answer: 11
Correct!
Question: 14 19 24 29 34 39 44 49 54 ..
Your answer: 59
Correct!
Congratulations, Bob!
```

### Пример: поражение (Калькулятор, НОД, Чётность, Простое число)

```console
Question: 15 - 17
Your answer: 0
'0' is wrong answer ;(. Correct answer was '-2'.
Let's try again, Bob!

Question: 95 40
Your answer: 1
'1' is wrong answer ;(. Correct answer was '5'.
Let's try again, Bob!

Question: 35
Your answer: n
'n' is wrong answer ;(. Correct answer was 'no'.
Let's try again, Bob!

Question: 19
Your answer: yes
Correct!
Question: 39
Your answer: yes
'yes' is wrong answer ;(. Correct answer was 'no'.
Let's try again, Bob!
```

Записи asciinema пока нет — вместо неё здесь текстовые сессии из реального запуска.

---

<details>
<summary>Автоматические тесты Хекслета</summary>

Тесты запускаются на каждый коммит. За запуск отвечает файл `.github/workflows/hexlet-check.yml` — не удаляйте и не переименовывайте ни его, ни репозиторий.

</details>

## О Хекслете

[Хекслет](https://ru.hexlet.io/) — школа программирования: авторские программы обучения с практикой, поддержкой наставников и реальными проектами, которые остаются в резюме. Этот репозиторий — один из таких проектов.
