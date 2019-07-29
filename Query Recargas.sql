create database recargas

create table TelcelTae(
	sku varchar(6),
	producto varchar(100),
	costo decimal(10,2)
)

create table TelcelAmigoSinLimite(
	sku varchar(6),
	producto varchar(100),
	costo decimal(10,2)
)

create table TelcelInternet(
	sku varchar(6),
	producto varchar(100),
	costo decimal(10,2)
)

create table Alo(
	sku varchar(6),
	producto varchar(100),
	costo decimal(10,2)
)

create table Movistar(
	sku varchar(6),
	producto varchar(100),
	costo decimal(10,2)
)

create table AtatIusacell(
	sku varchar(6),
	producto varchar(100),
	costo decimal(10,2)
)

create table Unefon(
	sku varchar(6),
	producto varchar(100),
	costo decimal(10,2)
)

create table Nextel(
	sku varchar(6),
	producto varchar(100),
	costo decimal(10,2)
)

create table VirginMobile(
	sku varchar(6),
	producto varchar(100),
	costo decimal(10,2)
)

create table Recarga(
	no_transaccion int identity(1,1) primary key,
	telefono varchar(10),
	sku varchar(13),
	fecha_hora varchar(19),
	cve_estado varchar(2),
	cuentaCadena int,
	cuentaEstablecimiento int,
	cuentaTerminal int,
	cuentaCajero varchar(10),
	cuentaClave varchar(20),
	code varchar(5),
	descripcion varchar(120),
	producto varchar(100)
)

create table PagoServicio(
	no_transaccion int identity(1,1) primary key,
	referencia_1 varchar(50),
	referencia_2 varchar(10),
	sku varchar(13),
	fecha_hora varchar(19),
	monto decimal(10,2),
	cuentaCadena int,
	cuentaEstablecimiento int,
	cuentaTerminal int,
	cuentaCajero int,
	cuentaClave varchar(10)
)

create table CodigoRespuesta(
	code varchar(5) primary key,
	descripcion varchar(120),
	causa varchar(150),
	mensajePantalla varchar(100)
)

insert into TelcelTae values('00001' ,'$20.00 TELCEL', 20.00)
insert into TelcelTae values('00002' ,'$30.00 TELCEL', 30.00)
insert into TelcelTae values('00003' ,'$50.00 TELCEL', 50.00)
insert into TelcelTae values('00004' ,'$100.00 TELCEL', 100.00)
insert into TelcelTae values('00005' ,'$150.00 TELCEL', 150.00)
insert into TelcelTae values('00006' ,'$200.00 TELCEL', 200.00)
insert into TelcelTae values('00007' ,'$300.00 TELCEL', 300.00)
insert into TelcelTae values('00008' ,'$500.00 TELCEL', 500.00)

insert into TelcelAmigoSinLimite values('PA20' ,'Amigo sin Limite 20', 20.00)
insert into TelcelAmigoSinLimite values('PA30' ,'Amigo sin Limite 30', 30.00)
insert into TelcelAmigoSinLimite values('PA50' ,'Amigo sin Limite 50', 50.00)
insert into TelcelAmigoSinLimite values('SL100' ,'Amigo sin Limite 100', 100.00)
insert into TelcelAmigoSinLimite values('SL150' ,'Amigo sin Limite 150', 150.00)
insert into TelcelAmigoSinLimite values('SL200' ,'Amigo sin Limite 200', 200.00)
insert into TelcelAmigoSinLimite values('SL300' ,'Amigo sin Limite 300', 300.00)
insert into TelcelAmigoSinLimite values('SL500' ,'Amigo sin Limite 500', 500.00)

insert into TelcelInternet values('INT20', 'Internet 20', 20.00)
insert into TelcelInternet values('INT30', 'Internet 30', 30.00)
insert into TelcelInternet values('ILIM30', 'Internet 20', 30.00)
insert into TelcelInternet values('INT50', 'Internet 50', 50.00)
insert into TelcelInternet values('INT100', 'Internet 100', 100.00)
insert into TelcelInternet values('INT150', 'Internet 150', 150.00)
insert into TelcelInternet values('INT200', 'Internet 200', 200.00)
insert into TelcelInternet values('INT300', 'Internet 300', 300.00)
insert into TelcelInternet values('INT500', 'Internet 500', 500.00)

insert into Alo values('00010', 'Tiempo aire Al� 20', 20.00)
insert into Alo values('00011', 'Tiempo aire Al� 30', 30.00)
insert into Alo values('00012', 'Tiempo aire Al� 50', 50.00)
insert into Alo values('00098', 'Tiempo aire Al� 100', 100.00)
insert into Alo values('00099', 'Tiempo aire Al� 150', 150.00)
insert into Alo values('00100', 'Tiempo aire Al� 200', 200.00)
insert into Alo values('00101', 'Tiempo aire Al� 300', 300.00)
insert into Alo values('00102', 'Tiempo aire Al� 500', 500.00)

insert into Movistar values('00014','$20.00 MOVISTAR', 20.00)
insert into Movistar values('00015','$30.00 MOVISTAR', 30.00)
insert into Movistar values('00016','$50.00 MOVISTAR', 50.00)
insert into Movistar values('00018','$100.00 MOVISTAR', 100.00)
insert into Movistar values('00020','$150.00 MOVISTAR', 150.00)
insert into Movistar values('00021','$200.00 MOVISTAR', 200.00)
insert into Movistar values('00023','$300.00 MOVISTAR', 300.00)
insert into Movistar values('00024','$500.00 MOVISTAR', 500.00)

insert into AtatIusacell values('00096', '$20.00 AT&T / IUSACELL', 20.00)
insert into AtatIusacell values('00095', '$30.00 AT&T / IUSACELL', 30.00)
insert into AtatIusacell values('00069', '$50.00 AT&T / IUSACELL', 50.00)
insert into AtatIusacell values('00070', '$100.00 AT&T / IUSACELL', 100.00)
insert into AtatIusacell values('00071', '$150.00 AT&T / IUSACELL', 150.00)
insert into AtatIusacell values('00072', '$200.00 AT&T / IUSACELL', 200.00)
insert into AtatIusacell values('00073', '$300.00 AT&T / IUSACELL', 300.00)
insert into AtatIusacell values('00074', '$500.00 AT&T / IUSACELL', 500.00)

insert into Unefon values('00093', '$20.00 UNEFON', 20.00)
insert into Unefon values('00094', '$30.00 UNEFON', 30.00)
insert into Unefon values('00076', '$50.00 UNEFON', 50.00)
insert into Unefon values('00077', '$100.00 UNEFON', 100.00)
insert into Unefon values('00078', '$150.00 UNEFON', 150.00)
insert into Unefon values('00079', '$200.00 UNEFON', 200.00)
insert into Unefon values('00080', '$300.00 UNEFON', 300.00)
insert into Unefon values('00081', '$500.00 UNEFON', 500.00)

insert into Nextel values('00097', '$20.00 Nextel', 20.00)
insert into Nextel values('00044', '$30.00 Nextel', 30.00)
insert into Nextel values('00045', '$50.00 Nextel', 50.00)
insert into Nextel values('00046', '$100.00 Nextel', 100.00)
insert into Nextel values('00090', '$150.00 Nextel', 200.00)
insert into Nextel values('00047', '$200.00 Nextel', 300.00)
insert into Nextel values('00091', '$300.00 Nextel', 300.00)
insert into Nextel values('00048', '$500.00 Nextel', 500.00)

insert into VirginMobile values('00060','$20.00 VIRGIN',20.00)
insert into VirginMobile values('00061','$30.00 VIRGIN',30.00)
insert into VirginMobile values('00063','$50.00 VIRGIN',50.00)
insert into VirginMobile values('00064','$100.00 VIRGIN',100.00)
insert into VirginMobile values('00065','$150.00 VIRGIN',150.00)
insert into VirginMobile values('00066','$200.00 VIRGIN',200.00)
insert into VirginMobile values('00067','$300.00 VIRGIN',300.00)
insert into VirginMobile values('00068','$500.00 VIRGIN',500.00)

insert into CodigoRespuesta values('0', 'Transacci�n aprobada.', 'La operacion se realizo satisfactoriamente. Ninguna acci�n es requerida', 'N/A')
insert into CodigoRespuesta values('-1', 'C�digo de producto invalido', 'El c�digo que se est� enviando no existe en la base de datos.', 'N/A')
insert into CodigoRespuesta values('-2', 'La tienda/Terminal no est� registrada', 'Las claves que se est�n enviando de la tienda, punto de venta no est�n registradas en la base de datos', 'NO FUE POSIBLE REGISTRAR LA TERMINAL')
insert into CodigoRespuesta values('-3', 'TimeOut Proveedor', 'Tiempo de espera con el proveedor ha excedido', '')
insert into CodigoRespuesta values('-4', 'Denegada. La transacci�n no aplica.', 'La transacci�n es denegada por no cumplir ciertos parametros de autorizaci�n.', '')
insert into CodigoRespuesta values('-5', 'Cadena sin Saldo', 'La Cadena cuenta con saldo insuficiente para realizar una recarga.', 'SALDO INSUFICIENTE')
insert into CodigoRespuesta values('-6', 'Error Indeterminado en Aplicaci�n', 'Error de aplicaci�n de la plataforma MTCenter.', '')
insert into CodigoRespuesta values('-7', 'Error de Base de Datos', 'Error indeterminado en la Base de Datos de Proveedor', '')
insert into CodigoRespuesta values('-8', 'Error de Autenticaci�in', 'No se pudo procesar la solicitud ya que algunos de los datos de la cuenta de acceso son inv�lidos.', '')
insert into CodigoRespuesta values('-9', 'Par�metros Incorrectos', 'Alguno de los parametros enviados tiene contenido no v�lido', '')
insert into CodigoRespuesta values('-600', 'Transacci�n no Encontrada', 'Indica que la transacci�n a�n se encuentra en proceso, por lo que es necesario realizar de nueva cuenta la consulta', '')
insert into CodigoRespuesta values('5', 'Error. Existi� un error indeterminado en el proceso de la transacci�n.', 'No es posible procesar la transacci�n debido a un error indeterminado', '')
insert into CodigoRespuesta values('7', 'Error. Existi� un error al guardar el registro en la base de datos', 'No es posible guardar el registro en la base de datos', '')
insert into CodigoRespuesta values('8', 'Timeout Emisor', 'La Telef�nica no ha respondido', '')
insert into CodigoRespuesta values('9', 'No existe Original', 'No existe transacci�n original para ser reversada.', '')
insert into CodigoRespuesta values('12', 'Transacci�n inv�lida', 'La transacci�n no esta permitida, ed decir, no es un abono a tiempo aire.', '')
insert into CodigoRespuesta values('19', 'Contador de Venta incorrecto', 'El conteo de las transacciones est� iniciando en cero y debe ser mayor.', '')
insert into CodigoRespuesta values('30', 'Error de formato. Existe alg�n problema con el tipo de datos del mensaje.', 'Existe un error en el formato o datos del mensaje. Revisar la mensajeria o los datos introducidos y reintentar', '')
insert into CodigoRespuesta values('34', 'Sospecha de fraude.', 'La transacci�n se sospecha fue un fraude.', '')
insert into CodigoRespuesta values('35', 'N�mero de Tel�fono inv�lido', 'El tel�fono no pertenece a Tel�fonica M�viles o es inv�lido, o contiene caracteres no v�lidos. Revisar los datos introducidos y reintentar.', '')
insert into CodigoRespuesta values('65', 'Bloqueo de por exceder el l�mite de venta permitido', 'Se da cuando la tienda supera en un tiempo determinado un l�mite de venta', '')
insert into CodigoRespuesta values('66', 'Error en la base de datos', 'Error al actualizar el cr�dito de la tienda. Aplica para la telefon�a publica', '')
insert into CodigoRespuesta values('67', 'Cr�dito insuficiente', 'La tienda no tiene cr�dito disponible para realizar la recarga. Aplica para la tel�fonia publica', '')
insert into CodigoRespuesta values('71', 'Sin respuesta del switch', 'El switch no est� contestando las solicitudes del abono', '')
insert into CodigoRespuesta values('72', 'Timeout del Carrier', 'El Carrier supera el tiempo de respuesta', '')
insert into CodigoRespuesta values('87', 'Tel�fono no susceptible de abono', 'Telef�nica no aplicable', '')
insert into CodigoRespuesta values('88', 'Monto Invalido', 'Error en la cantidad a recargar', '')
insert into CodigoRespuesta values('91', 'Emisor o ruteador inoperativo', 'El ruteador est� deshabilitado. Levantar el proceso para activar el servicio o no hay conexi�n con ORACLE', '')
insert into CodigoRespuesta values('92', 'La instituci�n financiera no ha podido ser encontrada.', '', '')
insert into CodigoRespuesta values('93', 'Adquiriente Inv�lido', 'El c�digo del adquiriente no corresponde a los adquirientes registrados en el sistema', '')
insert into CodigoRespuesta values('96', 'Error de sistema.', 'Existe un error fatal en el sistema. Favor de reportarlo inmediatamente a Soporte t�cnico', '')
insert into CodigoRespuesta values('98', 'Reversa Duplicada', 'Se intent� reversar una transacci�n que ya hab�a sido reversada.', '')
insert into CodigoRespuesta values('99', 'Requerimiento en progreso.', 'No se puede procesar la transacci�n en este momento, debido a que se encuentra en proceso una transacci�n de caracter�sticas similares', '')


