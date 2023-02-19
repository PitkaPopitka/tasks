CREATE TABLE products
(
	id SERIAL PRIMARY KEY NOT NULL,
	prod_name VARCHAR(80) NOT NULL
);

INSERT INTO products(prod_name)
VALUES
('POCO X3 Pro 256 ГБ'),
('Apple iPhone 11 128 ГБ'),
('Samsung Galaxy S20 FE 128 ГБ'),
('Samsung Galaxy S22 Ultra 512 ГБ'),
('AOC Q27G2S/EU'),
('Xiaomi Mi Desktop Monitor 1С'),
('LG UltraGear 27GL83A-B'),
('Kingston NV1'),
('Samsung 980 PRO');

CREATE TABLE categories
(
	id SERIAL PRIMARY KEY NOT NULL,
	ctg_name VARCHAR(60) NOT NULL
);

INSERT INTO categories(ctg_name)
VALUES
('смартфон'),
('накопитель');

CREATE TABLE ProdCtg
(
	prod_id SERIAL NOT NULL,
	ctg_id SERIAL NOT NULL,
	FOREIGN KEY (prod_id) REFERENCES products(id),
	FOREIGN KEY (ctg_id) REFERENCES categories(id)
);

INSERT INTO ProdCtg
VALUES
(1, 1),
(2, 1),
(3, 1),
(4, 1),
(8, 2),
(9, 2);

SELECT prod_name, ctg_name FROM products
LEFT JOIN ProdCtg ON products.id = ProdCtg.prod_id
LEFT JOIN categories ON ProdCtg.ctg_id = categories.id