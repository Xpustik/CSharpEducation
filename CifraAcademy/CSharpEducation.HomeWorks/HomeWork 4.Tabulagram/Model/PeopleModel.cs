using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_4.Tabulagram.Model
{

  /// <summary>
  /// Перечисление, предоставляющие профессии(должности) в системе
  /// </summary>
  public enum PeopleRole
  {
    /// <summary>
    /// Роль рабочего
    /// </summary>
    Worker,

    /// <summary>
    /// Роль техника
    /// </summary>
    Technician,

    /// <summary>
    /// Роль программиста
    /// </summary>
    Programmer,

    /// <summary>
    /// Роль инженера
    /// </summary>
    Engineer
  }

  internal class PeopleModel
  {
    /// <summary>
    /// Получает или устанавливает Имя в системе
    /// </summary>
    public string FirstName { get; set; }
    
    /// <summary>
    /// Получает или устанавливает фамилию в системе
    /// </summary>
    public string LastName { get; set; }

    /// <summary>
    /// Получает или устанавливает адресс электронной почты в системе
    /// </summary>
    public string Email { get; set; }

    /// <summary>
    /// Получает или устанавливает должность в системе
    /// </summary>
    public PeopleRole Role { get; set; }

    /// <summary>
    /// Инициализирует новый экземпляр класса PeopleModel с указанными параметрами.
    /// </summary>
    /// <param name="firstName"> Имя сотрудника </param>
    /// <param name="lastName"> Фамилия сотрудника </param>
    /// <param name="email"> Адрес электронной почты сотрудника </param>
    /// <param name="role"> Профессия(должность) сотрудника </param>
    public PeopleModel(string firstName, string lastName, string email, PeopleRole role) 
    {
      FirstName = firstName;
      LastName = lastName;
      Email = email;
      Role = role;
    }

    /// <summary>
    /// Возвращает строковое представление сотрудника.
    /// </summary>
    /// <returns>Строка, содержащая информацию о пользователе.</returns>
    public override string ToString()
    {
      return $"{FirstName} {LastName} ({Role}) - {Email}";
    }

  }
}
