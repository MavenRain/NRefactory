﻿// 
// ConvertExplicitToImplicitImplementation.cs
// 
// Author:
//      Mansheng Yang <lightyang0@gmail.com>
// 
// Copyright (c) 2012 Mansheng Yang <lightyang0@gmail.com>
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
using System;
using System.Linq;
using System.Threading;
using System.Collections.Generic;
using Microsoft.CodeAnalysis.CodeRefactorings;
using Microsoft.CodeAnalysis;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CodeActions;
using Microsoft.CodeAnalysis.Text;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using ICSharpCode.NRefactory6.CSharp.Refactoring;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Simplification;
using Microsoft.CodeAnalysis.Formatting;

namespace ICSharpCode.NRefactory6.CSharp.Refactoring
{
	//TODO: Why only method ?
	[NRefactoryCodeRefactoringProvider(Description = "Convert explicit implementation of an interface method to implicit implementation")]
	[ExportCodeRefactoringProvider("Convert explicit to implict implementation", LanguageNames.CSharp)]
	public class ConvertExplicitToImplicitImplementationAction : SpecializedCodeAction<MethodDeclarationSyntax>
	{
		protected override IEnumerable<CodeAction> GetActions(SemanticModel semanticModel, SyntaxNode root, TextSpan span, MethodDeclarationSyntax node, CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}
	
//		protected override CodeAction GetAction (SemanticModel context, MethodDeclaration node)
//		{
//			if (node.PrivateImplementationType.IsNull)
//				return null;
//
//			if (!node.NameToken.Contains (context.Location) && 
//				!node.PrivateImplementationType.Contains(context.Location))
//				return null;
//
//			var method = (IMethod)((MemberResolveResult)context.Resolve (node)).Member;
//			var type = method.DeclaringType;
//
//			// find existing method with the same signature
//			if (type.GetMethods (m => m.Name == node.Name && m.TypeParameters.Count == method.TypeParameters.Count
//				&& !m.IsExplicitInterfaceImplementation)
//				.Any (m => ParameterListComparer.Instance.Equals (m.Parameters, method.Parameters)))
//				return null;
//
//			return new CodeAction (context.TranslateString ("Convert explict to implicit implementation"),
//				script =>
//				{
//					var implicitImpl = (MethodDeclaration)node.Clone ();
//					implicitImpl.PrivateImplementationType = AstType.Null;
//
//					// remove visibility modifier, in case the code contains error
//					implicitImpl.Modifiers &= ~Modifiers.VisibilityMask;
//
//					implicitImpl.Modifiers |= Modifiers.Public;
//					script.Replace (node, implicitImpl);
//				}, 
//			node.NameToken);
//		}
	}
}
