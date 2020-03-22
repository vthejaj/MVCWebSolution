create table categories (
CatCode varchar(10) constraint categories_pk primary key,
CatDesc varchar(50) constraint categories_catdesc_nn not null
)

create table products (
ProdId int identity (100,1) constraint products_pk primary key,
ProdName varchar(30) constraint products_prodname_nn not null,
Price money constraint
products_price_chk check (price>=0),
Qoh int default 0,
Remarks varchar(100),
CatCode varchar(10) constraint products_catcode_fk
references categories (catcode ) on delete cascade
)

create table sales (
Invno int identity constraint sales_invno_pk primary key,
Prodid int constraint
sales_prodid_fk references products(prodid),
Transdate datetime,
Qty int constraint
sales_qty_chk check(qty > 0 ),
Amount money
);