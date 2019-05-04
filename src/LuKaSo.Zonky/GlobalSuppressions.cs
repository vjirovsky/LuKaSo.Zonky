﻿
// This file is used by Code Analysis to maintain SuppressMessage 
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given 
// a specific target and scoped to a namespace, type, member, etc.

[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Minor Code Smell", "S1075:URIs should not be hardcoded", Justification = "Hardcoded part of URL, that will never change, it is part of public API", Scope = "member", Target = "~M:LuKaSo.Zonky.Api.ZonkyApi.CreatePrimaryMarketInvestmentAsync(LuKaSo.Zonky.Api.Models.Markets.PrimaryMarketInvestment,LuKaSo.Zonky.Api.Models.Login.AuthorizationToken,System.Threading.CancellationToken)~System.Threading.Tasks.Task")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Minor Code Smell", "S1075:URIs should not be hardcoded", Justification = "Hardcoded part of URL, that will never change, it is part of public API", Scope = "member", Target = "~M:LuKaSo.Zonky.Api.ZonkyApi.GetInvestmentsAsync(System.Int32,System.Int32,LuKaSo.Zonky.Api.Models.Login.AuthorizationToken,System.Threading.CancellationToken)~System.Threading.Tasks.Task{System.Collections.Generic.IEnumerable{LuKaSo.Zonky.Api.Models.Investments.Investment}}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Minor Code Smell", "S1075:URIs should not be hardcoded", Justification = "Hardcoded part of URL, that will never change, it is part of public API", Scope = "member", Target = "~M:LuKaSo.Zonky.Api.ZonkyApi.GetWalletAsync(LuKaSo.Zonky.Api.Models.Login.AuthorizationToken,System.Threading.CancellationToken)~System.Threading.Tasks.Task{LuKaSo.Zonky.Api.Models.Investor.Wallet}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Minor Code Smell", "S1075:URIs should not be hardcoded", Justification = "Hardcoded part of URL, that will never change, it is part of public API", Scope = "member", Target = "~M:LuKaSo.Zonky.Api.ZonkyApi.GetWalletTransactionsAsync(LuKaSo.Zonky.Api.Models.FilterOptions,LuKaSo.Zonky.Api.Models.Login.AuthorizationToken,System.Threading.CancellationToken)~System.Threading.Tasks.Task{System.Collections.Generic.IEnumerable{LuKaSo.Zonky.Api.Models.Investor.WalletTransaction}}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Minor Code Smell", "S1075:URIs should not be hardcoded", Justification = "Hardcoded part of URL, that will never change, it is part of public API", Scope = "member", Target = "~M:LuKaSo.Zonky.Api.ZonkyApi.GetNotificationsAsync(System.Int32,LuKaSo.Zonky.Api.Models.Login.AuthorizationToken,System.Threading.CancellationToken)~System.Threading.Tasks.Task{System.Collections.Generic.IEnumerable{LuKaSo.Zonky.Api.Models.Investor.Notification}}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Minor Code Smell", "S1075:URIs should not be hardcoded", Justification = "Hardcoded part of URL, that will never change, it is part of public API", Scope = "member", Target = "~M:LuKaSo.Zonky.Api.ZonkyApi.GetBlockedAmountAsync(LuKaSo.Zonky.Api.Models.Login.AuthorizationToken,System.Threading.CancellationToken)~System.Threading.Tasks.Task{System.Collections.Generic.IEnumerable{LuKaSo.Zonky.Api.Models.Investor.BlockedAmount}}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Minor Code Smell", "S1075:URIs should not be hardcoded", Justification = "Hardcoded part of URL, that will never change, it is part of public API", Scope = "member", Target = "~M:LuKaSo.Zonky.Api.ZonkyApi.GetPrimaryMarketPlaceAsync(System.Int32,System.Int32,LuKaSo.Zonky.Api.Models.FilterOptions,System.Threading.CancellationToken)~System.Threading.Tasks.Task{System.Collections.Generic.IEnumerable{LuKaSo.Zonky.Api.Models.Loans.Loan}}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Minor Code Smell", "S1075:URIs should not be hardcoded", Justification = "Hardcoded part of URL, that will never change, it is part of public API", Scope = "member", Target = "~M:LuKaSo.Zonky.Api.ZonkyApi.GetSecondaryMarketplaceAsync(System.Int32,System.Int32,LuKaSo.Zonky.Api.Models.FilterOptions,System.Threading.CancellationToken)~System.Threading.Tasks.Task{System.Collections.Generic.IEnumerable{LuKaSo.Zonky.Api.Models.Markets.SecondaryMarketOffer}}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Minor Code Smell", "S1075:URIs should not be hardcoded", Justification = "Hardcoded part of URL, that will never change, it is part of public API", Scope = "member", Target = "~M:LuKaSo.Zonky.Api.ZonkyApi.#ctor(System.Net.Http.HttpClient)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Major Code Smell", "S1121:Assignments should not be made from within sub-expressions", Justification = "Usage is complient with exception of this warning, ad documentation of SonarLint", Scope = "member", Target = "~M:LuKaSo.Zonky.Client.ZonkyClient.GetAllInvestmentsAsync(System.Threading.CancellationToken)~System.Threading.Tasks.Task{System.Collections.Generic.IEnumerable{LuKaSo.Zonky.Api.Models.Investments.Investment}}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Minor Code Smell", "S1075:URIs should not be hardcoded", Justification = "<Pending>", Scope = "member", Target = "~M:LuKaSo.Zonky.Api.ZonkyApi.GetInvestmentsAsync(System.Int32,System.Int32,LuKaSo.Zonky.Models.Login.AuthorizationToken,System.Threading.CancellationToken)~System.Threading.Tasks.Task{System.Collections.Generic.IEnumerable{LuKaSo.Zonky.Models.Investments.Investment}}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Minor Code Smell", "S1075:URIs should not be hardcoded", Justification = "<Pending>", Scope = "member", Target = "~M:LuKaSo.Zonky.Api.ZonkyApi.CreatePrimaryMarketInvestmentAsync(LuKaSo.Zonky.Models.Markets.PrimaryMarketInvestment,LuKaSo.Zonky.Models.Login.AuthorizationToken,System.Threading.CancellationToken)~System.Threading.Tasks.Task")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Minor Code Smell", "S1075:URIs should not be hardcoded", Justification = "<Pending>", Scope = "member", Target = "~M:LuKaSo.Zonky.Api.ZonkyApi.GetWalletAsync(LuKaSo.Zonky.Models.Login.AuthorizationToken,System.Threading.CancellationToken)~System.Threading.Tasks.Task{LuKaSo.Zonky.Models.Investor.Wallet}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Minor Code Smell", "S1075:URIs should not be hardcoded", Justification = "<Pending>", Scope = "member", Target = "~M:LuKaSo.Zonky.Api.ZonkyApi.GetWalletTransactionsAsync(LuKaSo.Zonky.Models.FilterOptions,LuKaSo.Zonky.Models.Login.AuthorizationToken,System.Threading.CancellationToken)~System.Threading.Tasks.Task{System.Collections.Generic.IEnumerable{LuKaSo.Zonky.Models.Investor.WalletTransaction}}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Minor Code Smell", "S1075:URIs should not be hardcoded", Justification = "<Pending>", Scope = "member", Target = "~M:LuKaSo.Zonky.Api.ZonkyApi.GetNotificationsAsync(System.Int32,LuKaSo.Zonky.Models.Login.AuthorizationToken,System.Threading.CancellationToken)~System.Threading.Tasks.Task{System.Collections.Generic.IEnumerable{LuKaSo.Zonky.Models.Investor.Notification}}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Minor Code Smell", "S1075:URIs should not be hardcoded", Justification = "<Pending>", Scope = "member", Target = "~M:LuKaSo.Zonky.Api.ZonkyApi.GetBlockedAmountAsync(LuKaSo.Zonky.Models.Login.AuthorizationToken,System.Threading.CancellationToken)~System.Threading.Tasks.Task{System.Collections.Generic.IEnumerable{LuKaSo.Zonky.Models.Investor.BlockedAmount}}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Minor Code Smell", "S1075:URIs should not be hardcoded", Justification = "<Pending>", Scope = "member", Target = "~M:LuKaSo.Zonky.Api.ZonkyApi.GetPrimaryMarketPlaceAsync(System.Int32,System.Int32,LuKaSo.Zonky.Models.FilterOptions,System.Threading.CancellationToken)~System.Threading.Tasks.Task{System.Collections.Generic.IEnumerable{LuKaSo.Zonky.Models.Loans.Loan}}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Minor Code Smell", "S1075:URIs should not be hardcoded", Justification = "<Pending>", Scope = "member", Target = "~M:LuKaSo.Zonky.Api.ZonkyApi.GetSecondaryMarketplaceAsync(System.Int32,System.Int32,LuKaSo.Zonky.Models.FilterOptions,System.Threading.CancellationToken)~System.Threading.Tasks.Task{System.Collections.Generic.IEnumerable{LuKaSo.Zonky.Models.Markets.SecondaryMarketOffer}}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Major Code Smell", "S1121:Assignments should not be made from within sub-expressions", Justification = "<Pending>", Scope = "member", Target = "~M:LuKaSo.Zonky.Client.ZonkyClient.GetAllInvestmentsAsync(System.Threading.CancellationToken)~System.Threading.Tasks.Task{System.Collections.Generic.IEnumerable{LuKaSo.Zonky.Models.Investments.Investment}}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Minor Code Smell", "S1075:URIs should not be hardcoded", Justification = "<Pending>", Scope = "member", Target = "~M:LuKaSo.Zonky.Api.ZonkyApi.GetWalletTransactionsAsync(LuKaSo.Zonky.Models.Login.AuthorizationToken,LuKaSo.Zonky.Models.FilterOptions,System.Threading.CancellationToken)~System.Threading.Tasks.Task{System.Collections.Generic.IEnumerable{LuKaSo.Zonky.Models.Investor.WalletTransaction}}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Major Code Smell", "S1121:Assignments should not be made from within sub-expressions", Justification = "<Pending>", Scope = "member", Target = "~M:LuKaSo.Zonky.Client.ZonkyClient.GetAllPrimaryMarketPlaceAsync(LuKaSo.Zonky.Models.FilterOptions,System.Threading.CancellationToken)~System.Threading.Tasks.Task{System.Collections.Generic.IEnumerable{LuKaSo.Zonky.Models.Loans.Loan}}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Major Code Smell", "S1121:Assignments should not be made from within sub-expressions", Justification = "<Pending>", Scope = "member", Target = "~M:LuKaSo.Zonky.Client.ZonkyClient.GetAllSecondaryMarketplaceAsync(LuKaSo.Zonky.Models.FilterOptions,System.Threading.CancellationToken)~System.Threading.Tasks.Task{System.Collections.Generic.IEnumerable{LuKaSo.Zonky.Models.Markets.SecondaryMarketOffer}}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Minor Code Smell", "S1075:URIs should not be hardcoded", Justification = "<Pending>", Scope = "member", Target = "~M:LuKaSo.Zonky.Extesions.UriExtensions.Append(System.Uri,System.String)~System.Uri")]