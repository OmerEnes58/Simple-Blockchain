using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpChainModel
{
	public class Block
	{
		public string PrvHash;
		public DateTime TimeStamp;
		public List<Transaction> Transactions;
		public string Hash;
		public ulong Nonce;

		public Block(DateTime timeStamp, List<Transaction> transactions, string previousHash)
		{
			this.TimeStamp = timeStamp;
			this.PrvHash = previousHash;
			this.Transactions = transactions;
			this.Hash = "";
			this.Nonce = 0;
		}
	}
}
