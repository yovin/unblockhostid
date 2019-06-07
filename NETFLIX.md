![Netflix Error Playback](https://www.ghacks.net/wp-content/uploads/2016/02/netflix-error-unblocker.jpg)

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

[Modified](https://files.catbox.moe/54sx6d.zip) / [Mirror](https://rspace.me/6860a6f61f) / [Mirror2](https://filebin.ca/4jivtUll4uI3/goodbyedpi-0.1.5rc1.zip) / [Mirror3](https://bin.jvnv.net/file/YuJJa/goodbyedpi-0.1.5rc1.zip) / [Mirror4](https://upload.vinahost.vn/YHIyh/goodbyedpi-0.1.5rc1.zip) / [Mirror5](https://transfer.sh/WVcuw/goodbyedpi-0.1.5rc1.zip) / [Mirror6](https://filebin.net/4nfk9he6qlhyads2) (Thanks to punkofthedeath - Tinggal extract lalu run install_service.cmd as Administrator.)

Saya sarankan untuk menggunakan versi modified karena menginstallnya hanya sekali klik dan untuk menghapusnya juga mudah. Tetapi jika kalian mengerti cara menggunakan aplikasi tersebut silahkan pakai yang original.

Selesai, silahkan coba untuk memutar film di Netflix.


# Linux

Coming soon..

```https://github.com/bol-van/zapret```

### Example installation on debian 7
----------------------------
Debian 7 originally contains the kernel 3.2. It cannot do DNAT on localhost.

Of course, it is possible not to bind tpws to 127.0.0.1 and replace "DNAT 127.0.0.1" in the iptables rules with "REDIRECT", but it's better to install a fresher core. It is in a stable repository:

 apt-get update
 
 apt-get install linux-image-3.16
 
Install packages :

 apt-get update
 
 apt-get install libnetfilter-queue-dev ipset curl
 
Copy the "zapret" directory to /opt.

Build nfqws :

 cd /opt/zapret/nfq
 
 make
 
Collect tpws:

 cd /opt/zapret/tpws
 
 make
 
Copy /opt/zapret/init.d/debian7/zapret to /etc/init.d.

In /etc/init.d/zapret, select "ISP". Depending on it the necessary rules will be applied.

In the same place, select the SLAVE_ETH parameter corresponding to the name of the internal network interface.

Enable autostart : chkconfig zapret on

(optional) Manually get a new list of ip addresses for the first time : /opt/zapret/ipset/get_antizapret.sh

Click on the sheet update task :

 crontab -e
 
 Create a line "0 12 * * */2 /opt/zapret/ipset/get_antizapret.sh". This means to update the list at 12:00 every 2 days.
 
Start the service : service zapret start

Try going somewhere: http://ej.ru, http://kinozal.tv, http://grani.ru.

If it does not work, stop the zapret service and add the rule to the iptables manually,

start nfqws in the terminal under a turn with the required parameters.

Try to connect to blocked sites, watch the program output.

If there is no response, it means that the queue number is probably incorrect or the destination ip is not on the ipset.

If there is a reaction, but blocking is not enough, it means that the bypass parameters are not correct, or it is a means doesn't work for your ISP in your case.

Nobody said it would work everywhere.

Try dumping in wireshark or "tcpdump -vvv -X host <ip>", see if you really have the first the TCP segment goes short and whether the "Host:" register changes.

### ubuntu 12.14
------------

There is a ready-made configuration for upstart : zapret.conf. It needs to be copied to /etc/init and configured in a similar way to debian.

Starting the service : "start zapret"

Stop service : "stop zapret"

View messages : cat /var/log/upstart/zapret.log

Ubuntu 12 is equipped with kernel 3.2, just like debian 7. See the note in the "debian 7" section.

### ubuntu 16,debian 8
------------------

The process is similar to debian 7, but you need to register init scripts in systemd after copying them to /etc/init.d.

By default, lsb-core may not be installed.

apt-get update

apt-get --no-install-recommends install lsb-core

install : /usr/lib/lsb/install_initd zapret

remove : /usr/lib/lsb/remove_initd zapret

start : sytemctl start zapret

stop : systemctl stop zapret

status, output messages : systemctl status zapret

### Other linux systems
--------------------

There are several basic service launchers: sysvinit, upstart, systemd.

The configuration depends on the system used in your distribution.

A typical strategy is to find a script or configuration to run other services and write your own by analogy,

if necessary, read the documentation on the startup system.

The necessary commands can be taken from the proposed scripts.
