﻿/*
    Copyright (C) 2014-2016 de4dot@gmail.com

    This file is part of dnSpy

    dnSpy is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    dnSpy is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with dnSpy.  If not, see <http://www.gnu.org/licenses/>.
*/

namespace dnSpy.Scripting.Roslyn.Common {
	/// <summary>
	/// Roslyn scripting text view roles
	/// </summary>
	static class RoslynReplTextViewRoles {
		/// <summary>
		/// Roslyn REPL (any supported language, eg. C# and Visual Basic)
		/// </summary>
		public const string RoslynRepl = "dnSpy-RoslynRepl";

		/// <summary>
		/// C# REPL
		/// </summary>
		public const string CSharpRepl = "dnSpy-CSharpRepl";

		/// <summary>
		/// Visual Basic REPL
		/// </summary>
		public const string VisualBasicRepl = "dnSpy-VisualBasicRepl";
	}
}
