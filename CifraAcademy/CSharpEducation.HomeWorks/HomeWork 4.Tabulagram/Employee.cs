using HomeWork_4.Tabulagram.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_4.Tabulagram
{
  internal class Employee : PeopleModel
  {
    public int Id { get; set; }
    
    public Employee(int id, string firstName, string lastName, string email, PeopleRole role) 
      : base(firstName, lastName, email, role) 
    {
      Id = id;
    }
  }
}
