# Школа "Learn"

Проект создан по заказу на школу "Learn", для ознакомления услуг школы для слушателей и их родителей.

## Начало работы

Эти инструкции предоставят вам копию проекта и помогут запустить на вашем локальном компьютере для разработки и тестирования.

### Необходимые условия

* Для того, чтобы проект корректно запустился, необхадима среда Visual Studio 2016 и новее
* Библиотека Net Framework
* Cервер системы управления базами данных Microsoft Sql Server. (Есть возможность локального подключения)
* MSS Managment Studio - Среда разработки и администрирования баз данных

### Установка

**Для начало необхадимо скачать среду Visual Studio**

Чем новее среда, тем лучше, рекомендуется Visual Studio 2019 Community.

	Visual Studio 2019 Community - бесплатная среда разработки, пробный период которой не ограничен
	если вы создадите учетную запись, среда подходит для обучения, бесплатна для обучающихся и участников
	открытого исходного кода.


**Затем нужно скачать Microsoft Sql Server**

	Microsoft Sql Server - это система управления базами данных (СУБД), также имеется
	бесплатная неограниченная версия, подходящая для проверки работоспособности и обучения.

**Затем нужно скачать MSS Managment Studio**

	MSS Managment Studio - это среда разработки и администрирования баз данных sql server

**После этапов выше, нужно восстановить базу данных файл - файл LearnSchoolBackup.bak**

	Правый клик по базам данных - восстановить (Выбирите LearnSchoolBackup.bak)


---

### Подготовка приложения к работе

Чтобы приложение коректно запустилось необхадимо заменить название ***ORIGAMI*** во всех атрибутах connectionString в тэгах add, сгрупированных в тэге connectionStrings файла App.config проекта на название вашего сервера (По умолчанию это название вашего компьютера, которое можно просмотреть в свойствах компьютера или при подключении к ядру в MSS Managment Studio)

Было:
```
App.config
    <ConnectionStrings>
    <add name = "MSSconnection" connectionString="data source = ORIGAMI; initial catalog..."/>
    <add name = "Something" connectionString="data source = ORIGAMI; initial catalog..."/>
    .
    .
    .
    <ConnectionStrings/>
```

Стало (*Вместо _MY_SERVER_NAME_ название вешего сервера*):

```
App.config
    <ConnectionStrings>
    <add name = "MSSconnection" connectionString="data source = _MY_SERVER_NAME_; initial catalog..."/>
    <add name = "Something" connectionString="data source = _MY_SERVER_NAME_; initial catalog..."/>
    .
    .
    .
    <ConnectionStrings/>
```

Финал

	После запуска проекта, скампилированные файлы exe можно использовать как приложение, не запуская их в среде
	VisualStudio, для этого клиените правой кнопкой мыши по проекту, перейдите в директорию проекта, в папку bin\debug
	там будут скампилированные файлы вашей программы.


## Автор

[**Wildcat2k21**](https://github.com/Wildcat2k21)
