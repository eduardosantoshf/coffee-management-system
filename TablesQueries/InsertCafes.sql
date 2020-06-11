INSERT INTO Cafes.Cafe(NIF,nome,morada) VALUES(411766585,'E-Cafe','Rua da Buba');

INSERT INTO Cafes.Cafe_Bar(NIF,nome,morada) VALUES(411766585,'E-Cafe','Rua da Buba');
INSERT INTO Cafes.Cafe_Pastelaria(NIF,nome,morada) VALUES(411766585,'E-Cafe','Rua da Buba');
INSERT INTO Cafes.Cafe_Restaurante([NIF],[nome],[morada]) VALUES(411766585,'E-Cafe','Rua da Buba');

INSERT INTO Cafes.Pessoa([NIF],[nome]) VALUES(296969668,'Angelica Maldonado'),(132063497,'Megan Wise'),(687643810,'Tate Stout'),(723657350,'Magee Carey'),(236696799,'Axel Lowe'),(497784251,'Noelani Freeman'),(443138848,'Connor Brady'),(547916021,'Branden Cherry'),(142550724,'Xenos Brady'),(231915681,'Haviva Holloway');
INSERT INTO Cafes.Pessoa([NIF],[nome]) VALUES(241045237,'Winifred Walter'),(259143494,'Uma Mason'),(293595015,'Quentin Santana'),(810577576,'Avye Hancock'),(452467352,'Price Whitfield'),(896728691,'Chiquita Head'),(918313660,'Demetria Erickson'),(770167696,'Hadassah Mcdonald'),(481192418,'Arthur Greene'),(802270517,'Iliana Ballard');
INSERT INTO Cafes.Pessoa([NIF],[nome]) VALUES(379923298,'Anjolie Peck'),(508174850,'Medge Trevino'),(884448426,'Gay Bond'),(608068232,'Martin Estrada'),(353381104,'Frances Douglas'),(369437051,'Leroy Everett'),(568333318,'Candace Case'),(477154900,'Honorato Crawford'),(797610436,'Sara Wilkins'),(899461477,'Gary Roy');
INSERT INTO Cafes.Pessoa([NIF],[nome]) VALUES(513196871,'Jared Berg'),(321972703,'Jacob Guy'),(900541552,'Walker Fox'),(369024440,'Bruce Hines'),(593505493,'Shad Gill'),(766186809,'Joan Guthrie'),(225537635,'Fuller Glass'),(949597097,'Libby Francis'),(268189127,'Dylan Maynard'),(323856495,'Aaron Valdez');
INSERT INTO Cafes.Pessoa([NIF],[nome]) VALUES(513696290,'John Franklin'),(235889530,'Iris Greene'),(799631594,'Alana Tyson'),(429529859,'Roth Holcomb'),(894940017,'Cameron Nieves'),(294939603,'Chastity Gay'),(629328443,'Beau Phillips'),(332426721,'Ginger Mclaughlin'),(874054574,'Medge Frost'),(455491867,'Yvonne Lowery');

--Admins
INSERT INTO Cafes.Pessoa([NIF],[nome]) VALUES(820473910,'Joaquim Freitas'),(836401127,'Diogo Moreira'),(806344901,'Eduardo Santos'),(322850048,'Professor');

--INSERT INTO Cafes.Cliente([NIF],[nome],[no_mesa]) VALUES(296969668,'Angelica Maldonado',14),(132063497,'Megan Wise',46),(687643810,'Tate Stout',17),(723657350,'Magee Carey',9),(236696799,'Axel Lowe',18),(497784251,'Noelani Freeman',4),(443138848,'Connor Brady',7),(547916021,'Branden Cherry',5),(142550724,'Xenos Brady',38),(231915681,'Haviva Holloway',37);
--INSERT INTO Cafes.Empregado([NIF],[NIF_cafe],[idade],[nome],[data_inic_contrato]) VALUES(241045237,211327138,81,'Winifred Walter','2016-01-20'),(259143494,211327138,38,'Uma Mason','2017-03-03'),(293595015,211327138,98,'Quentin Santana','2020-12-20'),(810577576,211327138,62,'Avye Hancock','2016-02-19'),(452467352,211327138,61,'Price Whitfield','2019-12-19'),(896728691,211327138,4,'Chiquita Head','2019-08-31'),(918313660,211327138,90,'Demetria Erickson','2018-07-15'),(770167696,211327138,80,'Hadassah Mcdonald','2021-02-03'),(481192418,211327138,96,'Arthur Greene','2018-07-25'),(802270517,211327138,41,'Iliana Ballard','2016-08-24');

--INSERT INTO Cafes.Cozinheiro([NIF],[NIF_cafeR],[idade],[nome],[data_inic_contrato]) VALUES (379923298,183370700,32,'Anjolie Peck','2016-09-15'),(508174850,183370700,34,'Medge Trevino','2019-05-26'),(884448426,183370700,35,'Gay Bond','2020-03-15'),(608068232,183370700,48,'Martin Estrada','2021-03-28'),(353381104,183370700,33,'Frances Douglas','2020-09-02'),(369437051,183370700,25,'Leroy Everett','2020-04-20'),(568333318,183370700,50, 'Candace Case','2018-03-11'),(477154900,183370700,47,'Honorato Crawford','2016-08-19'),(797610436,183370700,49,'Sara Wilkins','2018-06-15'),(899461477,183370700,50,'Gary Roy','2020-05-16');
--INSERT INTO Cafes.Pasteleiro([NIF],[NIF_cafeP],[idade],[nome],[data_inic_contrato]) VALUES (513196871,358222851,43,'Jared Berg','2016-07-17'),(321972703,358222851,50,'Jacob Guy','2016-09-10'),(900541552,358222851,46,'Walker Fox','2018-11-19'),(369024440,358222851,28,'Bruce Hines', '2020-10-04'),(593505493,358222851,55,'Shad Gill','2020-03-01'),(766186809,358222851,41,'Joan Guthrie','2020-11-08'),(225537635,358222851,40,'Fuller Glass','2016-10-08'),(949597097,358222851,21,'Libby Francis','2016-08-01'),(268189127,358222851,33,'Dylan Maynard','2019-04-27'),(323856495,358222851,51,'Aaron Valdez', '2016-08-23');
--INSERT INTO Cafes.Bartender([NIF],[NIF_cafeB],[idade],[nome],[data_inic_contrato]) VALUES (513696290,577791382,24,'John Franklin','2016-05-28'),(235889530,577791382,28,'Iris Greene','2017-05-12'),(799631594,577791382,41,'Alana Tyson','2016-08-12'),(429529859,577791382,43,'Roth Holcomb', '2017-06-26'),(894940017,577791382,47,'Cameron Nieves','2020-03-01'),(629328443,577791382,26,'Beau Phillips','2018-04-17'),(294939603,577791382,28,'Chastity Gay','2016-05-30'),(332426721,577791382,19,'Ginger Mclaughlin', '2018-01-03'),(874054574,577791382,46,'Medge Frost','2019-04-16'),(455491867,577791382,21,'Yvonne Lowery','2019-03-11');


--INSERT admins
EXEC insertAdministrador 'profBD', 'BD2020', 322850048, 'Professor';
EXEC insertAdministrador 'quimf', 'nice934', 820473910, 'Joaquim Freitas';
EXEC insertAdministrador 'didi', '123', 836401127, 'Diogo Moreira';
EXEC insertAdministrador 'dudu', '321', 806344901, 'Eduardo Santos';






