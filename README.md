# Arcades
##Предисловие
Проект над которым я работаю в данное время - классический Arcanoid для мобильных устройств.

Спросите, чего тут такого, наклепал блоков и готово, однако смотря как подойти к задаче.

Абсолютно в каждой вакансии есть "знание/понимание ООП". В данном случае можно прибегнуть к самому очевидному, сделать один блок, а потом с помощью наследования и полиморфизма разбить его на обычный, необычный, неразрушимый.

А по пути я наткнулся на интереснейшее видео с разработкой редактора непосредственно в самом Unity, чтобы можно было быстро эти самые блоки расставить по сетке, сохранить как уровень в ScriptableObject, а в дальнейшем, при запуске игры, генерировать кнопки и загружать соответствующие им уровни.

Не назвал бы эти видео уроками, потому что в них голый код и почти ничего не объясняется, к тому же, как отметили в одном комментарии 
>Код на уровне мидла

Из-за чего, хоть готовый пример был передо мной, во многом пришлось долго и упорно разбираться.
И таким образом самый простой Арканоид становится интересной задачей стоящей внимания.

Кстати, много вакансий типа "Hyper Casual Games", в которых, я более чем уверен, используется подобный подход разработки.

В рамках проекта был получен опыт работы с :

- 2D спрайтами и атласами
- Системой ScriptableObject
- Физикой 2D объектов
- Внутриигровыми покупками
- Сохранение и использование внутриигровых данных
- Внутриигровым магазином и инструментом In App Purchasing(IAP)

Также были разработаны: 

- Собственный редактор внутри движка Unity, для быстрой сборки уровней
- Система "энергии" и таймера восстановления
- Углубление в принципы ООП и их реализация, а не простое жонглирование GameObject-ами


Проект находится в разработке, однако основа готова и функционирует, планируется добавление нескольких игровых фич и общая доработка.
К сожалению, нет возможности добавить проект в GooglePlay из-за чего не функционирует магазин и нвозможна реализация таблицы рекордов он-лайн.

С проектом можно ознакомиться здесь:
https://phizis.itch.io/sirtet-arcades

##Послесловие
Проект всё ещё находится в разработке и будет дополнятся, по крайней мере, пока я не найду работу! :)
Из билжайших дополнений:
- Добавить систему "жизней" игрока
- Доделать экран настроек, пока что там будет только вклучение/отключение звуков, для этого надо поглубже разобраться с Микшером. Где-то видел что можно делать группы отдельно для игровых звуков и отдельно для музыки.
- Немного переработать магазин
- Нарисовать бэкграунд, как для меню, так и для игры, да и в целом переосмыслить дизайн
- Добавить игру Space ship trooper, вместо экрана "coming soon"
