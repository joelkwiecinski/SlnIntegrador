﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Ayudantes
{
    public static class UtilidadesFechas
    {

        public static int CalcularEdad(DateTime fechaNacimiento)
        {
            if (fechaNacimiento.DayOfYear < DateTime.Today.DayOfYear)
            {
                return DateTime.Today.Year - fechaNacimiento.Year;
            }
            else
            {
                return (DateTime.Today.Year - 1) - fechaNacimiento.Year;
            }
        }

    }
}
