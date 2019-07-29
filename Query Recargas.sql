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

insert into Alo values('00010', 'Tiempo aire Alò 20', 20.00)
insert into Alo values('00011', 'Tiempo aire Alò 30', 30.00)
insert into Alo values('00012', 'Tiempo aire Alò 50', 50.00)
insert into Alo values('00098', 'Tiempo aire Alò 100', 100.00)
insert into Alo values('00099', 'Tiempo aire Alò 150', 150.00)
insert into Alo values('00100', 'Tiempo aire Alò 200', 200.00)
insert into Alo values('00101', 'Tiempo aire Alò 300', 300.00)
insert into Alo values('00102', 'Tiempo aire Alò 500', 500.00)

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

insert into CodigoRespuesta values('0', 'Transacciòn aprobada.', 'La operacion se realizo satisfactoriamente. Ninguna acciòn es requerida', 'N/A')
insert into CodigoRespuesta values('-1', 'Còdigo de producto invalido', 'El còdigo que se està enviando no existe en la base de datos.', 'N/A')
insert into CodigoRespuesta values('-2', 'La tienda/Terminal no està registrada', 'Las claves que se estàn enviando de la tienda, punto de venta no estàn registradas en la base de datos', 'NO FUE POSIBLE REGISTRAR LA TERMINAL')
insert into CodigoRespuesta values('-3', 'TimeOut Proveedor', 'Tiempo de espera con el proveedor ha excedido', '')
insert into CodigoRespuesta values('-4', 'Denegada. La transacciòn no aplica.', 'La transacciòn es denegada por no cumplir ciertos parametros de autorizaciòn.', '')
insert into CodigoRespuesta values('-5', 'Cadena sin Saldo', 'La Cadena cuenta con saldo insuficiente para realizar una recarga.', 'SALDO INSUFICIENTE')
insert into CodigoRespuesta values('-6', 'Error Indeterminado en Aplicaciòn', 'Error de aplicaciòn de la plataforma MTCenter.', '')
insert into CodigoRespuesta values('-7', 'Error de Base de Datos', 'Error indeterminado en la Base de Datos de Proveedor', '')
insert into CodigoRespuesta values('-8', 'Error de Autenticaciòin', 'No se pudo procesar la solicitud ya que algunos de los datos de la cuenta de acceso son invàlidos.', '')
insert into CodigoRespuesta values('-9', 'Paràmetros Incorrectos', 'Alguno de los parametros enviados tiene contenido no vàlido', '')
insert into CodigoRespuesta values('-600', 'Transacciòn no Encontrada', 'Indica que la transacciòn aùn se encuentra en proceso, por lo que es necesario realizar de nueva cuenta la consulta', '')
insert into CodigoRespuesta values('5', 'Error. Existiò un error indeterminado en el proceso de la transacciòn.', 'No es posible procesar la transacciòn debido a un error indeterminado', '')
insert into CodigoRespuesta values('7', 'Error. Existiò un error al guardar el registro en la base de datos', 'No es posible guardar el registro en la base de datos', '')
insert into CodigoRespuesta values('8', 'Timeout Emisor', 'La Telefònica no ha respondido', '')
insert into CodigoRespuesta values('9', 'No existe Original', 'No existe transacciòn original para ser reversada.', '')
insert into CodigoRespuesta values('12', 'Transacciòn invàlida', 'La transacciòn no esta permitida, ed decir, no es un abono a tiempo aire.', '')
insert into CodigoRespuesta values('19', 'Contador de Venta incorrecto', 'El conteo de las transacciones està iniciando en cero y debe ser mayor.', '')
insert into CodigoRespuesta values('30', 'Error de formato. Existe algùn problema con el tipo de datos del mensaje.', 'Existe un error en el formato o datos del mensaje. Revisar la mensajeria o los datos introducidos y reintentar', '')
insert into CodigoRespuesta values('34', 'Sospecha de fraude.', 'La transacciòn se sospecha fue un fraude.', '')
insert into CodigoRespuesta values('35', 'Nùmero de Telèfono invàlido', 'El telèfono no pertenece a Telèfonica Mòviles o es invàlido, o contiene caracteres no vàlidos. Revisar los datos introducidos y reintentar.', '')
insert into CodigoRespuesta values('65', 'Bloqueo de por exceder el lìmite de venta permitido', 'Se da cuando la tienda supera en un tiempo determinado un lìmite de venta', '')
insert into CodigoRespuesta values('66', 'Error en la base de datos', 'Error al actualizar el crèdito de la tienda. Aplica para la telefonìa publica', '')
insert into CodigoRespuesta values('67', 'Crèdito insuficiente', 'La tienda no tiene crèdito disponible para realizar la recarga. Aplica para la telèfonia publica', '')
insert into CodigoRespuesta values('71', 'Sin respuesta del switch', 'El switch no està contestando las solicitudes del abono', '')
insert into CodigoRespuesta values('72', 'Timeout del Carrier', 'El Carrier supera el tiempo de respuesta', '')
insert into CodigoRespuesta values('87', 'Telèfono no susceptible de abono', 'Telefònica no aplicable', '')
insert into CodigoRespuesta values('88', 'Monto Invalido', 'Error en la cantidad a recargar', '')
insert into CodigoRespuesta values('91', 'Emisor o ruteador inoperativo', 'El ruteador està deshabilitado. Levantar el proceso para activar el servicio o no hay conexiòn con ORACLE', '')
insert into CodigoRespuesta values('92', 'La instituciòn financiera no ha podido ser encontrada.', '', '')
insert into CodigoRespuesta values('93', 'Adquiriente Invàlido', 'El còdigo del adquiriente no corresponde a los adquirientes registrados en el sistema', '')
insert into CodigoRespuesta values('96', 'Error de sistema.', 'Existe un error fatal en el sistema. Favor de reportarlo inmediatamente a Soporte tècnico', '')
insert into CodigoRespuesta values('98', 'Reversa Duplicada', 'Se intentò reversar una transacciòn que ya habìa sido reversada.', '')
insert into CodigoRespuesta values('99', 'Requerimiento en progreso.', 'No se puede procesar la transacciòn en este momento, debido a que se encuentra en proceso una transacciòn de caracterìsticas similares', '')


