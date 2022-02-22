using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ContSelf;
using System;
using System.Linq;
using ContSelf.Data;
namespace ContSelf.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ContSelfContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ContSelfContext>>()))
            {
                // Look for any movies.
                if (context.Funcionario.Any())
                {
                    return;   // DB has been seeded
                }

                context.Funcionario.AddRange(
                    new Funcionario
                    {
                        Nome = "Luiza",
                        DataNascimento = DateTime.Parse("1989-2-12"),
                        Salario = 1350.99M,
                        Atividades = "BLALBALBLLBALBLALBLABLALBLBLALBLABLALBLALBLALBAL"
                    },

                    new Funcionario
                    {
                        Nome = "Luiza",
                        DataNascimento = DateTime.Parse("1999-2-15"),
                        Salario = 1579.50M,
                        Atividades = "HEHEHHEHEHHAEHAUEAHUEHAUHDUASHODUHASOU"
                    },

                         new Funcionario
                    {
                        Nome = "Diogenes",
                        DataNascimento = DateTime.Parse("1984-1-23"),
                        Salario = 5350.99M,
                        Atividades = "LOLDOLAODLAOPIWEJANCZKOPHEQNO"
                    },

                         new Funcionario
                    {
                        Nome = "Fabricia",
                        DataNascimento = DateTime.Parse("1980-9-27"),
                        Salario = 7350.99M,
                        Atividades = "AAAAAAUTELOAAAAANEATCHAAAAAI"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}