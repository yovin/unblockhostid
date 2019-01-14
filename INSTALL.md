# Cara Install
Sebelumnya, download filenya dulu melalui link [ini](https://unblockhostid.github.io/), kemudian lanjut cara dibawah.

## Windows

Jalankan UNBLOCKHOSTID.exe dengan "Run as administrator", klik Apply

*Note: Mungkin akan terdeteksi sebagai virus, oleh karena itu matikan antivirus sebelum menggunakan.*

## Android

#**Root**#

**Manual**

Copy file hosts.

Buka folder /etc dan paste.

Akan ada peringatan replace, pilih replace.

Restart hp.

File hosts telah berhasil diinstall, silahkan cek sendiri dengan cara membuka website yang ada di daftar.

**Aplikasi**

Bisa juga melalui aplikasi AdAway yang bisa didownload [disini](https://f-droid.org/repo/org.adaway_61.apk)

Lalu install seperti biasa.

Buka dan grant akses root

Hapus semua centang pada hosts sources kemudian pilih add

```
https://raw.githubusercontent.com/gvoze32/unblockhostid/master/hosts
```

Salin kode diatas lalu kembali ke AdAway dan tambahkan

Centang opsi "Allow Redirections" di Settings (Thanks to @TrixPone)

Apply

#**Non-Root**#

Sebelumnya. install Hosts Go terlebih dahulu
https://play.google.com/store/apps/details?id=dns.hosts.server.change

Buka aplikasinya, klik "Hosts Setting", Pilih filenya (file hosts yang telah di download), kemudian start

## Linux / BSD / macOS

Buka terminal, lalu ketik atau salin kode di bawah ini lalu enter.

```
sudo curl -sfLS https://raw.githubusercontent.com/gvoze32/unblockhostid/master/hosts >> /etc/hosts
```

Alternative:
```
sudo wget https://raw.githubusercontent.com/gvoze32/unblockhostid/master/hosts -O /etc/hosts
```
