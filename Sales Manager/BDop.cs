using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sales_Manager
{
     class BDop
    {
        //Database connection object

       public bool conf, confPIN;
       public static SqlConnection bdCon = new SqlConnection("server=DESKTOP-5GGPQ22\\SQLEXPRESS; database=maasupply ; integrated security=true");
        SqlDataAdapter prodShow = new SqlDataAdapter("SELECT nProducto as Producto, idProducto as Código, catProducto as Categoría, unidadProducto as Unidades, precioProducto as Precio, totalProducto as Total FROM products", bdCon);
        DataSet data = new DataSet();

        //Log in void: validates the user in the database
        public void LogSQL(String uname, String upass)
        {
            SqlCommand logCheck = new SqlCommand($"select username,passwd from users where username='{uname}' and passwd='{upass}'", bdCon);

            bdCon.Open();
            logCheck.ExecuteNonQuery();
            SqlDataReader reg=logCheck.ExecuteReader();

            if (reg.Read())
            {
                conf = true;
                

            }
            else
            {
                MessageBox.Show("Nombre de Usuario o contraseña incorrecta");
            }
            bdCon.Close();
        }

        //Log pin void: validates the user admin in the database
        public void LogPIN(String content)
        {
            SqlCommand logCheck = new SqlCommand($"SELECT pinID FROM admins WHERE pinContent='{content}'", bdCon);

            bdCon.Open();
            
            logCheck.ExecuteNonQuery();
            SqlDataReader reg = logCheck.ExecuteReader();

            if (reg.Read())
            {
                confPIN = true;


            }
            else
            {
                MessageBox.Show("PIN incorrecto");
            }
            bdCon.Close();
        }

        //ADDING PRODUCTS

        public void addProducts(String pname,String category,int pstock,decimal price)
        {
            SqlCommand anadir = new SqlCommand($"insert into Products values ('{pname}','{category}','{pstock}','{price}','{pstock*price}');", bdCon);

            bdCon.Open();

            try
            {
                anadir.ExecuteNonQuery();
                MessageBox.Show($"EL PRODUCTO: {pname} SE AÑADIÓ CORRECTAMENTE");
            }
            catch
            {
                MessageBox.Show($"Ocurrió un error al añadir el producto: {pname}, VERIFIQUE LA INTEGRIDAD DE LOS DATOS SUMINISTRADOS O QUE EL PRODUCTO NO EXISTA EN INVENTARIO");
            }

            bdCon.Close();

        }
        //SHOWING  PRODUCTS
        public void ShowProducts(DataGridView inv)
        {
            
            bdCon.Open();
            prodShow.Fill(data, "Products");
            inv.DataSource = data.Tables["Products"].DefaultView;
            bdCon.Close();
        }

        //SEARCHING  PRODUCTS

        public void SearchProducts(dynamic inp, DataGridView dataV)
        {
            SqlDataAdapter result=new SqlDataAdapter($"select nProducto as Producto,idProducto as Código,catProducto as Categoría,unidadProducto as Unidades,precioProducto as Precio from Products where nProducto like '%{inp}%'  or catProducto like '%{inp}%' or unidadProducto like '%{inp}%' or precioProducto like '%{inp}% '", bdCon);
            bdCon.Open();
            result.Fill(data, "products");
            dataV.DataSource= data.Tables["products"].DefaultView;
            bdCon.Close();
        }

        //UPDATING PRODUCTS

        public void updateProds(String code,String pname, String category, int pstock, decimal price)
        {
            SqlCommand update = new SqlCommand($"update Products  set nProducto='{pname}', catProducto='{category}', unidadProducto='{pstock}',precioProducto='{price}',totalProducto='{pstock*price}' where idProducto='{code}';", bdCon);

            bdCon.Open();
            try
            {
                update.ExecuteNonQuery();
                MessageBox.Show($"PRODUCTO: {pname}, ACTUALIZADO CORRECTAMENTE");
            }
            catch
            {
                MessageBox.Show($"ERROR AL ACTUALIZAR EL PRODUCTO: {pname}, VERIFIQUE LAS MODIFICACIONES SUMINISTRADAS");
            }
            bdCon.Close();
        }

        //DELETING  PRODUCTS

        public void DeleteProducts(string delId,string nom)
        {
            SqlCommand delete = new SqlCommand($"DELETE FROM products WHERE idProducto='{delId}';", bdCon);
            bdCon.Open();

            try
            {
                delete.ExecuteNonQuery();
                MessageBox.Show($" EL PRODUCTO: {nom} , FUE ELIMINADO SATISFACTORIAMENTE");
            }
            catch(Exception ex)
            {
                MessageBox.Show($"ERROR AL ELIMINAR EL PRODUCTO: {nom} , VERIFIQUE LA INTEGRIDAD DE LOS DATOS");
            }
            bdCon.Close();
        }

        //FILLING CATS COMBOBOXES
        public void CatFill(ComboBox cb)
        {
            SqlCommand cbfil= new SqlCommand("select nomcat as Categoría from cats", bdCon);
            SqlDataReader rd;
            bdCon.Open();
            rd = cbfil.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Categoría");
            dt.Load(rd);
            cb.ValueMember = "Categoría";
            cb.DataSource = dt;
            bdCon.Close();
        }

        //ADDING NEW CATHEGORY 
        public void AddCat(string cname, string dcat)
        {
            SqlCommand addc = new SqlCommand($"insert into cats values ('{cname}','{dcat}')", bdCon);

            bdCon.Open();
            try {
                
                addc.ExecuteNonQuery();
                MessageBox.Show($"CATEGORÍA: {cname} AÑADIDA CORRECTAMENTE");

            }
            catch
            {
                MessageBox.Show($"ERROR AL AÑADIR CATEGORÍA: {cname}, VERIFIQUE QUE LOS DATOS FUERON INTRODUCIDOS CORRECTAMENTE O QUE NO EXISTA ACTUALMENTE LA CATEGORÍA AÑADIDA");
            }

            bdCon.Close();
        }

        //SHOWING CATHEGORIES

        public void ShowCats(DataGridView cat)
        {
            SqlDataAdapter scats= new SqlDataAdapter("select idCat as ID,nomcat as Nombre, descat as Descripción from cats", bdCon);

            bdCon.Open();
            scats.Fill(data, "products");
            cat.DataSource = data.Tables["products"].DefaultView;
            bdCon.Close();
        }

        //DELETING CATHEGORIES

        public void deleteCats(String no, String id)
        {
            SqlCommand delcats = new SqlCommand($"delete from cats where idCat='{id}'", bdCon);

            bdCon.Open();
            try
            {

                delcats.ExecuteNonQuery();
                MessageBox.Show($"CATEGORÍA: {no}, ELIMINADA CORRECTAMENTE");
                

            }
            catch
            {
                MessageBox.Show($"ERROR AL ELIMINAR CATEGORÍA: {no}, VERIFIQUE QUE LA CATEGORÍA SELECCIONADA EXISTA O NO HAYA SIDO ELIMINADA ANTERIORMENTE");
            }
            bdCon.Close();
        }

        //UPDATING CATHEGORIES

        public void updateCats(String nom, String id, String dec)
        {
            SqlCommand update = new SqlCommand($"update cats set nomcat='{nom}', descat='{dec}' where idCat='{id}';",bdCon);

            bdCon.Open();
            try
            {

                update.ExecuteNonQuery();
                MessageBox.Show($"CATEGORÍA: {nom}, ACTUALIZADA CORRECTAMENTE");

            }
            catch
            {
                MessageBox.Show($"ERROR AL ACTUALIZAR CATEGORÍA: {nom}, VERIFIQUE LA INTEGRIDAD DE LOS DATOS INTRODUCIDOS");
            }
            bdCon.Close();
        }

        //DECREASING STOCK VALUES

        public void decreStock(String id, int can)
        {
            SqlCommand decrease = new SqlCommand($"update products set unidadProducto=unidadProducto-'{can}' where idProducto='{id}';", bdCon);
            SqlCommand tosq1= new SqlCommand($"update products set totalProducto=unidadProducto*precioProducto where idProducto='{id}';", bdCon);

            bdCon.Open();
            
            try
            {
                decrease.ExecuteNonQuery();
                tosq1.ExecuteNonQuery();


            }
            catch
            {
                MessageBox.Show($"ERROR AL AÑADIR EL PRODUCTO AL CARRITO, VERIFIQUE QUE TENGA LAS UNIDADES SUFICIENTES EN INVENTARIO, ESTÉ SELECCIONADO O QUE EL PRODUCTO EXISTA");
            }
            bdCon.Close();
        }

        //ROLLBACK DECREASING STOCK VALUES

        public void rolldecreStock(String id, int can)
        {
            SqlCommand rdecrease = new SqlCommand($"update products set unidadProducto=unidadProducto+'{can}' where idProducto='{id}';", bdCon);
            SqlCommand tosq1 = new SqlCommand($"update products set totalProducto=unidadProducto*precioProducto where idProducto='{id}';", bdCon);
            bdCon.Open();
            try
            {

                rdecrease.ExecuteNonQuery();
                tosq1.ExecuteNonQuery();

            }
            catch
            {
                MessageBox.Show($"ERROR AL REMOVER EL PRODUCTO DEL CARRITO, VERIFIQUE QUE EL PRODUCTO ESTÉ SELECCIONADO");
            }
            bdCon.Close();
        }


        //RECORDING FACTURES

        public void rFactures(string name,string fech,string vem, string to)
        {
            SqlCommand getfact1 = new SqlCommand($"insert into facts values ('{name}','{vem}','{fech}','{to}');", bdCon);
            //                                    insert into cats values('{cname}','{dcat}')
            bdCon.Open();

            try 
            {
                getfact1.ExecuteNonQuery();
                MessageBox.Show("FACTURA GUARDADA CORRECTAMENTE");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"OCURRIÓ UN ERROR AL GUARDAR LA FACTURA "+ex);
            }
            bdCon.Close();


        }
        //GETTING FACTURE ID

        public string getFactId( string name, string fech,string v, string to)
        {
            string sen;
            SqlCommand getfact = new SqlCommand($"select idFactura from facts where nomCliente='{name}' and vend='{v}' and fechaCreacion='{fech}' and totalFactura='{to}';", bdCon);
            SqlDataReader rd;
            bdCon.Open();
            rd = getfact.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("idFactura");
            dt.Load(rd);
            sen=dt.Rows[0][0].ToString();
            bdCon.Close();
            return sen;

        }

        //GETTING TOTAL $

        public string getTotal()
        {
            string sen;
            SqlCommand gettotal = new SqlCommand($"  select sum(totalProducto) as 'suma' from products;", bdCon);
            SqlDataReader rd;
            bdCon.Open();
            rd = gettotal.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("suma");
            dt.Load(rd);
            sen= "RD$"+dt.Rows[0][0].ToString();
            bdCon.Close();
            return sen;

        }

        //SHOWING FACTURES

        public void showFac(DataGridView view)
        {
            SqlDataAdapter sfacts = new SqlDataAdapter("select idFactura as ID,nomCliente as Cliente,vend as Vendedor, fechaCreacion as Fecha,totalFactura as Total  from facts", bdCon);

            bdCon.Open();
            sfacts.Fill(data, "facts");
            view.DataSource = data.Tables["facts"].DefaultView;
            bdCon.Close();
        }

        //SEARCHING FACTURES

        public void searFacts(DataGridView view,dynamic inp)
        {
            SqlDataAdapter serfacts = new SqlDataAdapter($"select idFactura as ID,nomCliente as Cliente,vendedor as Vendedor, fechaCreacion as Fecha,totalFactura as Total  from facts where idFactura like '%{inp}%' or nomCliente like '%{inp}%' or fechaCreacion like '%{inp}%' or totalFactura like '%{inp}%'", bdCon);

            bdCon.Open();
            serfacts.Fill(data, "facts");
            view.DataSource = data.Tables["facts"].DefaultView;
            bdCon.Close();
        }

        //UPDATING FACTURES

        public void upFacts(string nom,string fech,string to, string id)
        {
            SqlCommand update = new SqlCommand($"update facts set nomCliente='{nom}', fechaCreacion='{fech}',totalFactura='{to}'  where idFactura='{id}';", bdCon);

            bdCon.Open();
            try
            {

                update.ExecuteNonQuery();
                MessageBox.Show($"FACTURA ACTUALIZADA CORRECTAMENTE");

            }
            catch
            {
                MessageBox.Show($"ERROR AL ACTUALIZAR LA FACTURA VERIFIQUE LA INTEGRIDAD DE LOS DATOS INTRODUCIDOS");
            }
            bdCon.Close();
        }

        public void delFacts(string id) {


            SqlCommand del = new SqlCommand($"delete from facts where idFactura='{id}'", bdCon);

            bdCon.Open();
            try
            {

                del.ExecuteNonQuery();
                MessageBox.Show($"FACTURA ELIMINADA CORRECTAMENTE");


            }
            catch
            {
                MessageBox.Show($"ERROR AL ELIMINAR LA FACTURA VERIFIQUE QUE LA CATEGORÍA SELECCIONADA EXISTA O NO HAYA SIDO ELIMINADA ANTERIORMENTE");
            }
            bdCon.Close();

        }

        //Daily Solds

        public string daySolds(string dat)
        {
            string sen;
            SqlCommand gettotal = new SqlCommand($"  select sum(totalFactura) as 'suma' from facts where fechaCreacion='{dat}';", bdCon);
            SqlDataReader rd;
            bdCon.Open();
            rd = gettotal.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("suma");
            dt.Load(rd);
            sen = "RD$" + dt.Rows[0][0].ToString();
            bdCon.Close();
            return sen;
        }

        public void SearchDaily(DataGridView dgv, string fech)
        {
            SqlDataAdapter adapter = new SqlDataAdapter($" select sum(totalFactura) as 'Total de Ventas' from facts where fechaCreacion='{fech}';", bdCon);
            bdCon.Open();
            adapter.Fill(data, "facts");
            dgv.DataSource = data.Tables["facts"].DefaultView;
            bdCon.Close();
        }

    }
}
