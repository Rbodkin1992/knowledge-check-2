using System;
using KnowledgeCheck2;

namespace knowledgeCheck2
{
    public class CatFood : Product
    {
        public string Flavor { get; set; } = string.Empty; // Ensures no null value
    }
}