using OperatorsSample.DTOs;
using OperatorsSample.Models;
using System;

namespace OperatorsSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var user1 = new User { Id = 1, Name = "Batman", Birth = new DateTime(1950, 10, 10), Email = "bat@cave.com" };
            var user2 = new User { Id = 2, Name = "John Snow", Birth = new DateTime(1990, 12, 12), Email = "john@snow.com" };
            var user3 = new User { Id = 3, Name = "Iron Man", Birth = new DateTime(1940, 01, 01), Email = "iron@man.com" };
            var user4 = new User { Id = 4, Name = "Joker", Birth = new DateTime(1920, 06, 06), Email = "thisisa@joke.com" };
            var user5 = new User { Id = 5, Name = "Thanos", Birth = new DateTime(1900, 01, 01), Email = "finger@snap.com" };
            var user6 = new User { Id = 6, Name = "Woody Woodpecker", Birth = new DateTime(1940, 03, 23), Email = "Woody@Woodpecker.com" };
            var user7 = new User { Id = 7, Name = "Darth Vader", Birth = new DateTime(1972, 10, 10), Email = "anakyn@empire.org" };

            var user1Dto = (UserDto)user1;
            Console.WriteLine($"DTO: {user1Dto.Name} - {user1Dto.Age}");

            if(user3 > user4)
                Console.WriteLine($"user3 {user3.Name} - {user3.CalcAge()} is older than user4 {user4.Name} - {user4.CalcAge()}");
            else
                Console.WriteLine($"user4 {user4.Name} - {user4.CalcAge()} is older than user3 {user3.Name} - {user3.CalcAge()}");

            var totalYears = user5 + user7;
            Console.WriteLine($"user5 ({user5.Name} - {user5.CalcAge()}) + user7 ({user7.Name} - {user7.CalcAge()}) = {totalYears}");

            Console.WriteLine();
        }
    }
}
