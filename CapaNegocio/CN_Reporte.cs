﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;
namespace CapaNegocio
{
    public class CN_Reporte
    {
        public List<Reporte> Ventas(string fechainicio, string fechafin, string idtransaccion)
        {
            return objCapaDato.Ventas(fechainicio, fechafin, idtransaccion);
        }

        private CD_Reporte objCapaDato = new CD_Reporte();
        public DashBoard VerDashBoard()
        {
            return objCapaDato.VerDashBoard();

        }
    }
}