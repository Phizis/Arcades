# Arcades
[English](https://github.com/Phizis/Arcades/blob/main/README.md#english)
## Предисловие

Проект над которым я работаю в данное время - классический Arcanoid для мобильных устройств.

Спросите, чего тут такого, наклепал блоков и готово, однако смотря как подойти к задаче.

Абсолютно в каждой вакансии есть "знание/понимание ООП". В данном случае можно прибегнуть к самому очевидному, сделать один блок, а потом с помощью наследования и полиморфизма разбить его на обычный, необычный, неразрушимый.

А по пути я наткнулся на интереснейшее видео с разработкой редактора непосредственно в самом Unity, чтобы можно было быстро эти самые блоки расставить по сетке, сохранить как уровень в *ScriptableObject*, а в дальнейшем, при запуске игры, генерировать кнопки и загружать соответствующие им уровни.

Не назвал бы эти видео уроками, потому что в них голый код и почти ничего не объясняется, к тому же, как отметили в одном комментарии 
>Код на уровне мидла

Из-за чего, хоть готовый пример был передо мной, во многом пришлось долго и упорно разбираться.
И таким образом самый простой Арканоид становится интересной задачей стоящей внимания.

Кстати, много вакансий типа "Hyper Casual Games", в которых, я более чем уверен, используется подобный подход разработки.

### В рамках проекта был получен опыт работы с :

- 2D спрайтами и атласами
- Системой ScriptableObject
- Физикой 2D объектов
- Внутриигровыми покупками и инструментом *In App Purchasing(IAP)*
- Сохранение и использование внутриигровых данных

Также были разработаны: 

- Собственный редактор внутри движка Unity, для быстрой сборки уровней
- Система "энергии" и таймера восстановления
- Углубление в принципы ООП и их реализация, а не простое жонглирование GameObject-ами


Проект находится в разработке, однако основа готова и функционирует, планируется добавление нескольких игровых фич и общая доработка.
К сожалению, нет возможности добавить проект в GooglePlay из-за чего не функционирует магазин и невозможна реализация таблицы рекордов он-лайн.

С проектом можно ознакомиться здесь:
https://phizis.itch.io/sirtet-arcades

## Послесловие

Проект всё ещё находится в разработке и будет дополнятся, по крайней мере, пока я не найду работу! :)
Из билжайших дополнений:
- Добавить систему "жизней" игрока
- Доделать экран настроек, пока что там будет только включение/отключение звуков, для этого надо поглубже разобраться с Микшером. Где-то видел что можно делать группы отдельно для игровых звуков и отдельно для музыки.
- Немного переработать магазин
- Нарисовать бэкграунд, как для меню, так и для игры, да и в целом переосмыслить дизайн
- Добавить игру *Space ship trooper*, вместо экрана "coming soon"

### English
## Background

The project I'm currently working on is classic Arcanoid for mobile devices.

Ask what's wrong here, place blocks and you're done, but depending on how you approach the task.

Absolutely in every vacancy there is "knowledge / understanding of OOP". In this case, you can resort to the most obvious, make one block and then using inheritance and polymorphism break it into ordinary, unusual, indestructible.

And along the way I came across an interesting video with the development of the editor directly in Unity, so that you can quickly arrange these same blocks on a grid, save them as a level in a *ScriptableObject*, and later, when you start the game, generate buttons and load the corresponding levels.

These videos was not a lessons, because it contain bare code and almost nothing is explained, besides as noted in one comment
>Middle level code

Because of that, even though a ready-made example was in front of me, I had to figure it out for a long time and hard.
And thus the simplest Arkanoid becomes an interesting problem worthy of attention.

By the way, there are a lot of vacancies like "Hyper Casual Games", which I'm more than sure use a similar development approach.

### As part of the project, experience was gained with:

- 2D sprites and atlases
- ScriptableObject system
- Physics of 2D objects
- In-app purchases and *In App Purchasing(IAP)* tool
- Saving and using in-game data

Also developed:

- Own editor inside the Unity engine, for quick assembly of levels
- Energy system and cooldown timer
- Deepening into the principles of OOP and their implementation, and not just juggling GameObjects


The project is under development, but the basis is ready and functioning, it is planned to add several game features and general refinement.
Unfortunately, there is no way to add the project to GooglePlay, which is why the store does not function and it is impossible to implement the table of records online.

The project can be found here:
https://phizis.itch.io/sirtet-arcades

## Afterword

The project is still in development and will be updated, at least until I find a job! :)
Of the upcoming additions:
- Add player "lives" system
- Complete the settings screen, for now there will only be turning on / off the sounds, for this you need to understand the Mixer more deeply. I saw somewhere that you can make groups separately for game sounds and separately for music.
- Slightly rework the store
- Draw a background, both for the menu and for the game and in general rethink the design
- Add a *Space ship trooper game*, instead of the "coming soon" screen
