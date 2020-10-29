using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFramework_linq;

namespace EntityFramework_linq.Repositorio
{
	class RepositorioCategoria
	{
		public void AdicionarCategoria(int id, string nome)
		{
			Categoria categoria = new Categoria();
			categoria.Id = id;
			categoria.Nome = nome;

			LojaEFEntities ef = new LojaEFEntities();
			ef.Categoria.Add(categoria);

			ef.SaveChanges();


		}

		public void AlterarCategoria(int id, string nome)
		{

			LojaEFEntities ef = new LojaEFEntities();
			var categoria = ef.Categoria.First(item => item.Id == id);

			categoria.Nome = nome;

			ef.SaveChanges();


		}

		public void ExcluirCategoria(int id)
		{

			LojaEFEntities ef = new LojaEFEntities();
			var categoria = ef.Categoria.First(x => x.Id == id);
			ef.Categoria.Remove(categoria);
			ef.SaveChanges();


		}



	}

}
