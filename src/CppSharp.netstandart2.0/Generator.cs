using CppSharp.AST;
using CppSharp.Generators;
using System.Collections.Generic;

namespace CppSharp.netstandart2._0
{
	public class Generator : ILibrary
	{
		public void Gen() 
		{ 
		}

		public void GenerateCode(Driver driver, List<GeneratorOutput> outputs)
		{
			throw new System.NotImplementedException();
		}

		public void Postprocess(Driver driver, ASTContext ctx)
		{
			throw new System.NotImplementedException();
		}

		public void Preprocess(Driver driver, ASTContext ctx)
		{
			throw new System.NotImplementedException();
		}

		public void Setup(Driver driver)
		{
			throw new System.NotImplementedException();
		}

		public void SetupPasses(Driver driver)
		{
			throw new System.NotImplementedException();
		}
	}
}
