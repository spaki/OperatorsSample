using OperatorsSample.DTOs;
using System;

namespace OperatorsSample.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Birth { get; set; }

        public int CalcAge() => (int)((DateTime.UtcNow - Birth).Days / 365.2425);

        public static implicit operator UserDto(User user) 
            => new UserDto {
                Id = user.Id,
                Name = user.Name,
                Email = user.Email,
                Birth = user.Birth,
                Age = user.CalcAge()
            };

        public static int operator +(User user1, User user2) => user1.CalcAge() + user2.CalcAge();

        public static int operator -(User user1, User user2) => user1.CalcAge() - user2.CalcAge();

        public static bool operator >(User user1, User user2) => user1.CalcAge() > user2.CalcAge();

        public static bool operator <(User user1, User user2) => user1.CalcAge() < user2.CalcAge();

        public static bool operator >=(User user1, User user2) => user1.CalcAge() >= user2.CalcAge();

        public static bool operator <=(User user1, User user2) => user1.CalcAge() <= user2.CalcAge();
    }
}
