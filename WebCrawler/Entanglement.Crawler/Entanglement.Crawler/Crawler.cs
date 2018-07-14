using System.Collections.Generic;
using System.Linq;
using Entanglement.Crawler.Entities;

namespace Entanglement.Crawler
{
	public class Crawler
	{
		private const int Cycles = 10;

		private IEnumerable<Company> Companies = new List<Company>();

		private IEnumerable<Person> Persons = new List<Person>();

		private IEnumerable<Mandate> Mandates = new List<Mandate>();

		public void Start()
		{
			for (int i = 0; i < Cycles; i++)
			{
				if (!Companies.Any() && !Persons.Any())
				{
					GetInitialCompanies();
				}

				if (Companies.Any())
				{
					CrawlCompanies();
				}

				if (Persons.Any())
				{
					CrawlPersons();
				}
			}
		}

		public void GetInitialCompanies()
		{

		}

		public void CrawlCompanies()
		{

		}

		public void CrawlPersons()
		{

		}
	}
}
