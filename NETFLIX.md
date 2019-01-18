![Netflix Error Playback](https://virgin.i.lithium.com/t5/image/serverpage/image-id/100977i5AAC1EF5255EEB5E?v=1.0)

Cara untuk menembus blokiran Netflix oleh Internet Positif Dengan menggunakan UNBLOCKHOSTID + GoodbyeDPI.

Setelah menginstall UNBLOCKHOSTID, kamu akan bisa membuka Netflix, tetapi saat masuk playback mode akan ada tulisan:

    ======================

    Oops, something when wrong....

    Internet Connection Problem

    An Internet or home network connection problem is preventing playback. Please check your Internet connection and try again.

    If the problem persists, please visit the Netflix Help Center.

    ======================

Kurang lebih seperti itu, karena akses kecepatan Netflix dilimit oleh Internet Positif jadi harus memakai GoodbyeDPI juga.

Kamu bisa download GoodbyeDPI disini.

[Original](https://github.com/ValdikSS/GoodbyeDPI)

[Modified](https://www.dropbox.com/s/uxqowf8dpkupkqn/GoodbyeDPI_Modified_By_Punkofthedeath.rar?dl=0) (Thanks to punkofthedeath - Tinggal extract lalu run install_service.cmd as Administrator.)

Saya sarankan untuk menggunakan versi modified karena menginstallnya hanya sekali klik dan untuk menghapusnya juga mudah. Tetapi jika kalian mengerti cara menggunakan aplikasi tersebut silahkan pakai yang original.

Selesai, silahkan coba untuk memutar film di Netflix.


# Linux

Coming soon..

```https://github.com/bol-van/zapret```

## Пример установки на debian 7
----------------------------
Debian 7 изначально содержит ядро 3.2. Оно не умеет делать DNAT на localhost.
Конечно, можно не привязывать tpws к 127.0.0.1 и заменить в правилах iptables "DNAT 127.0.0.1" на "REDIRECT",
но лучше установить более свежее ядро. Оно есть в стабильном репозитории :
 apt-get update
 apt-get install linux-image-3.16
Установить пакеты :
 apt-get update
 apt-get install libnetfilter-queue-dev ipset curl
Скопировать директорию "zapret" в /opt.
Собрать nfqws :
 cd /opt/zapret/nfq
 make
Собрать tpws :
 cd /opt/zapret/tpws
 make
Скопировать /opt/zapret/init.d/debian7/zapret в /etc/init.d.
В /etc/init.d/zapret выбрать пераметр "ISP". В зависимости от него будут применены нужные правила.
Там же выбрать параметр SLAVE_ETH, соответствующий названию внутреннего сетевого интерфейса.
Включить автостарт : chkconfig zapret on
(опционально) Вручную первый раз получить новый список ip адресов : /opt/zapret/ipset/get_antizapret.sh
Зашедулить задание обновления листа :
 crontab -e
 Создать строчку  "0 12 * * */2 /opt/zapret/ipset/get_antizapret.sh". Это значит в 12:00 каждые 2 дня обновлять список.
Запустить службу : service zapret start
Попробовать зайти куда-нибудь : http://ej.ru, http://kinozal.tv, http://grani.ru.
Если не работает, то остановить службу zapret, добавить правило в iptables вручную,
запустить nfqws в терминале под рутом с нужными параметрами.
Пытаться подключаться к заблоченым сайтам, смотреть вывод программы.
Если нет никакой реакции, значит скорее всего указан неверный номер очереди или ip назначения нет в ipset.
Если реакция есть, но блокировка не обходится, значит параметры обхода подобраные неверно, или это средство
не работает в вашем случае на вашем провайдере.
Никто и не говорил, что это будет работать везде.
Попробуйте снять дамп в wireshark или "tcpdump -vvv -X host <ip>", посмотрите действительно ли первый
сегмент TCP уходит коротким и меняется ли регистр "Host:".

## ubuntu 12,14
------------

Имеется готовый конфиг для upstart : zapret.conf. Его нужно скопировать в /etc/init и настроить по аналогии с debian.
Запуск службы : "start zapret"
Останов службы : "stop zapret"
Просмотр сообщений : cat /var/log/upstart/zapret.log
Ubuntu 12 так же, как и debian 7, оснащено ядром 3.2. См замечание в разделе "debian 7".

## ubuntu 16,debian 8
------------------

Процесс аналогичен debian 7, однако требуется зарегистрировать init скрипты в systemd после их копирования в /etc/init.d.
По умолчанию lsb-core может быть не установлен.
apt-get update
apt-get --no-install-recommends install lsb-core

install : /usr/lib/lsb/install_initd zapret
remove : /usr/lib/lsb/remove_initd zapret
start : sytemctl start zapret
stop : systemctl stop zapret
status, output messages : systemctl status zapret

## Другие linux системы
--------------------

Существует несколько основных систем запуска служб : sysvinit, upstart, systemd.
Настройка зависит от системы, используемой в вашем дистрибутиве.
Типичная стратегия - найти скрипт или конфигурацию запуска других служб и написать свой по аналогии,
при необходимости почитывая документацию по системе запуска.
Нужные команды можно взять из предложенных скриптов.
