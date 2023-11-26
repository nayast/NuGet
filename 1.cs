фамилии -> номер
insert into ClientOrder (idClient)
select Client.idClient, ClientOrder.Surname
from ClientOrder, Client
where ClientOrder.idClient = Client.Surname

grid adapter
DataSet ds = new DataSet();
using(...){
 conn.Open();
 sql = ...;
 SqlDataAdapter ada = new SqlDataAdapter(sql,conn);
 ada.Fill(ds);
}
like %.%
FullRowSelect
from-where-group by-order by- desc
заполнение панели: layout.Controls.Clear(); 
foreach (var .. in GetList()) Control item = new Control(class); layout.Controls.Add(item);
