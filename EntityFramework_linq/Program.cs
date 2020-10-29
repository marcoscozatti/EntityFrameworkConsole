using EntityFramework_linq.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_linq
{
	class Program
	{
		static void Main(string[] args)
		{
			//incluir
			new RepositorioCategoria().AdicionarCategoria(0, "Carros");
			new RepositorioCategoria().AdicionarCategoria(0, "Motos");

			//Alterar
			//new RepositorioCategoria().AlterarCategoria(9, "Frutas Doces");

			//Excluir
			//new RepositorioCategoria().ExcluirCategoria(11);



		}
	}
}
