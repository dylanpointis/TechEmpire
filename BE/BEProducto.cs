using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{

    public class BEProducto
    {
        public int CodigoProducto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Marca { get; set; }
        public string Color { get; set; }
        public string ImgUrl { get; set; }
        public double Precio { get; set; }
        public int Stock { get; set; }
        public int StockMax { get; set; }
        public int StockMin { get; set; }
        public bool BorradoLogico { get; set; }

        public BEProducto(int codigoProducto, string nombre, string descripcion, string marca, string color, string imgUrl, double precio, int stock, int smin, int smax, bool borrado)
        {
            this.CodigoProducto = codigoProducto;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.Marca = marca;
            this.Color = color;
            this.ImgUrl = imgUrl;
            this.Precio = precio;
            this.Stock = stock;
            this.StockMin = smin;
            this.StockMax = smax;
            this.BorradoLogico = borrado;
        }

    }
}
