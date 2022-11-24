using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.NewFolder
{
    internal class Product
    {
		private string _productname;

		public string Name
		{
			get => _productname;
			set 
			{
				if (value.Trim().Length>1)
				{
					_productname = value.Trim(); 

				}
				
			}
		}

		private float _productprice;

		public float Price
		{
			get => _productprice; 
			set 
			{
				if (value>0)
				{
					_productprice = value;

				}
				
			}
		}


	}
}
