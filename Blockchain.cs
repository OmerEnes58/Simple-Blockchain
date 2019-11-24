using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpChainModel
{
	public class Blockchain
	{
		public List<Block> Chain;
		public List<string> Nodes;
		public int Difficulty;
		public List<Transaction> PendingTransactions;
		public decimal MiningReward;
        public int BlockHalvings = 256;

		public Blockchain()
		{
			this.Chain = new List<Block>();
			this.Chain.Add(CreateGenesisBlock());

			this.Nodes = new List<string>();

			this.Difficulty = 2;
			this.PendingTransactions = new List<Transaction>();
            this.MiningReward = 50;
		}

		private Block CreateGenesisBlock()
		{
			Block genesis = new Block(new DateTime(2006, 12, 26), new List<Transaction>(), "0");
			return genesis;
		}
	}
}
