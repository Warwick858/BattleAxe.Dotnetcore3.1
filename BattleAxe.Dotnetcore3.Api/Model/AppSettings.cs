﻿// ******************************************************************************************************************
//  This file is part of BattleAxe.Dotnetcore3.
//
//  BattleAxe.Dotnetcore3 - bare-bones web service for dotnet core 3.1 using C# 8, with swagger and serilog ready.
//  Copyright(C)  2020  James LoForti
//  Contact Info: jamesloforti@gmail.com
//
//  BattleAxe.Dotnetcore3 is free software: you can redistribute it and/or modify
//  it under the terms of the GNU Affero General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
//  GNU Affero General Public License for more details.
//
//  You should have received a copy of the GNU Affero General Public License
//  along with this program.If not, see<https://www.gnu.org/licenses/>.
//									     ____.           .____             _____  _______   
//									    |    |           |    |    ____   /  |  | \   _  \  
//									    |    |   ______  |    |   /  _ \ /   |  |_/  /_\  \ 
//									/\__|    |  /_____/  |    |__(  <_> )    ^   /\  \_/   \
//									\________|           |_______ \____/\____   |  \_____  /
//									                             \/          |__|        \/ 
//
// ******************************************************************************************************************
//

namespace BattleAxe.Dotnetcore3.Api.Model
{
	public class AppSettings : IAppSettings
	{
		public string ApplicationName { get; set; } = string.Empty;
		public string Environment { get; set; } = string.Empty;
		public string SwaggerJsonUrl { get; set; } = string.Empty;
	} // end class
} // end namespace
