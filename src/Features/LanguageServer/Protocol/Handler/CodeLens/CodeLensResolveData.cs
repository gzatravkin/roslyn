﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.VisualStudio.LanguageServer.Protocol;

namespace Microsoft.CodeAnalysis.LanguageServer.Handler.CodeLens;

/// <summary>
/// Datatype storing the information needed to resolve a particular code lens item.
/// </summary>
/// <param name="ResultId">the resultId associated with the code lens list created on original request.</param>
/// <param name="ListIndex">the index of the specific code lens item in the original list.</param>
/// <param name="TextDocument">the text document associated with the code lens to resolve.</param>
internal sealed record CodeLensResolveData(long ResultId, int ListIndex, TextDocumentIdentifier TextDocument);
