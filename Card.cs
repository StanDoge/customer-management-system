using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clave5_Grupo9
{
  enum cardTypes
  {
    azul,
    dorado,
    platino
  }

  class Card
  {
    public double cardLimit;
    public double interestRate;
    public string date;
    public cardTypes card;

    public Card(double limit,double interest, cardTypes type )
    {
      cardLimit = limit;
      interestRate = interest;
      //asignacion del formato ISO en la fecha para evitar conflictos con la BD
      date = DateTime.Now.ToString("yyyy-MM-dd");
      card = type;
    }
  }
}
