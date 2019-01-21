attrib -r %WINDIR%\system32\drivers\etc\hosts
@ECHO OFF
IF "%OS%"=="Windows_NT" (
SET HOSTFILE=%windir%\system32\drivers\etc\hosts
) ELSE (
SET HOSTFILE=%windir%\hosts
)
ECHO 127.0.0.1 internetpositif.uzone.id www.internetpositif.uzone.id>> %HOSTFILE%
ECHO 127.0.0.1 uzone.id www.uzone.id>> %HOSTFILE%
ECHO 127.0.0.1 cfs.uzone.id>> %HOSTFILE%
ECHO 127.0.0.1 cfs2.uzone.id>> %HOSTFILE%
ECHO 127.0.0.1 u-ad.info>> %HOSTFILE%
ECHO 127.0.0.1 cfs.u-ad.info>> %HOSTFILE%
ECHO 127.0.0.1 cfs2.uadexchange.com>> %HOSTFILE%
attrib +r %WINDIR%\system32\drivers\etc\hosts
IPCONFIG -flushdns
CLS
ECHO UNBLOCKHOSTID
ECHO.
ECHO Situs yang terdaftar sudah ditambahkan ke file hosts kamu
ECHO.
PAUSE