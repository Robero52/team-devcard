# Team DevCard

Сайт-визитка команды с простым API на C# ASP.NET.

## Что внутри

- `frontend/` — HTML-страница с карточками команды и стилями
- `backend/TeamApi/` — API на ASP.NET, отдающее данные команды в JSON
- `.github/workflows/check.yml` — автоматическая проверка проекта (GitHub Actions)

## Как запустить

### 1. Запустить API

1. Открыть `backend/TeamApi/TeamApi.slnx` в Visual Studio
2. Нажать **F5**
3. Браузер откроется на `https://localhost:7076`
4. Проверка: перейти на `https://localhost:7076/api/team` — должен вернуться JSON

### 2. Открыть страницу

1. Открыть `frontend/index.html` в браузере (двойной клик по файлу)
2. Если API запущен — появятся карточки команды
3. Если API выключен — страница покажет сообщение «API недоступен»

## Эндпоинты API

- `GET /api/team` — возвращает список команды (JSON)
- `GET /api/ping` — проверка, что API живой (status, time, team)

## Стек

- HTML / CSS / JavaScript
- C# ASP.NET (.NET 8)
- Git / GitHub, GitHub Actions