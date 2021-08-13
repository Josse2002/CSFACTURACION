using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Facturacion.Entities
{
    public class Cliente
    {
        //PROPIEDADES DE CLASE
        public Int64 Id { get; set; }

        public string Nombres { get; set; }

        public string Apellidos { get; set; }

        public DateTime FechaNacimiento { get; set; }
        
        public string DUI { get; set; } 

        public string Municipio { get; set; }

        public string Departamento { get; set; }

        public string Telefono { get; set; }

        public string EMail { get; set; }

        public Cliente() { }

        public Cliente (Int64 pId, string pNombres, string pApellidos, DateTime pFechaNacimiento, 
            string pDUI, string pMunicipio, string pDepartamento, string pTelefono, string pEmail)
        {
            Id = pId;
            Nombres = pNombres;
            Apellidos = pApellidos;
            FechaNacimiento = pFechaNacimiento;
            DUI = pDUI;
            Municipio = pMunicipio;
            Departamento = pDepartamento;
            Telefono = pTelefono;
            EMail = pEmail;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Facturacion.Entities
{
    public class Producto
    {
        public Int64 Id { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public string Marca { get; set; }

        public string Modelo { get; set; }

        public Decimal Largo { get; set; }

        public Decimal Ancho { get; set; }

        public Decimal Alto { get; set; }
        
        public string Talla { get; set; }

        public string Color { get; set; }

        public Int64 IdProveedor { get; set; }

        public Producto() { }

        public Producto(Int64 pId, string pNombre, string pDescripcion, string pMarca, string pModelo, Decimal pLargo,
            Decimal pAncho, Decimal pAlto, string pTalla, string pColor, Int64 pIdProveedor)
        {
            Id = pId;
            Nombre = pNombre;
            Descripcion = pDescripcion;
            Marca = pMarca;
            Modelo = pModelo;
            Largo = pLargo;
            Ancho = pAncho;
            Alto = pAlto;
            Talla = pTalla;
            Color = pColor;
            IdProveedor = pIdProveedor;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Facturacion.Entities
{
    public class Proveedor
    {
        public Int64 Id { get; set; }
        
        public string Direccion { get; set; }

        public string Municipio { get; set; }

        public string Departamento { get; set; }

        public string Telefono { get; set; }

        public string Email { get; set; }

        public string RazonSocial { get; set; }

        public Proveedor() { }

        public Proveedor(Int64 pId, string pDireccion, string pMunicipio, string pDepartamento, 
            string pTelefono, string pEmail, string pRazonSocial)
        {
            Id = pId;
            Direccion = pDireccion;
            Municipio = pMunicipio;
            Departamento = pDepartamento;
            Telefono = pTelefono;
            Email = pEmail;
            RazonSocial = pRazonSocial;

        }
    }
}
