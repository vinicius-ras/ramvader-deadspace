/*
 * Copyright (C) 2016 Vinicius Rogério Araujo Silva
 * 
 * This file is part of RAMvader-DeadSpace.
 * 
 * RAMvader-DeadSpace is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 * 
 * RAMvader-DeadSpace is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with RAMvader-DeadSpace. If not, see <http://www.gnu.org/licenses/>.
 */

/* This file keeps definitions for code elements which are part of the low-level features of the trainer. */
using RAMvader.CodeInjection;
using System;

namespace TrainerApp
{
	/// <summary>Identifiers for all cheats available in the trainer.</summary>
	public enum ECheat
	{
		/// <summary>Identifier for the "Infinite HP" cheat.</summary>
		evCheatInfiniteHP,
		/// <summary>Identifier for the "Infinite Ammo" cheat.</summary>
		evCheatInfiniteAmmo,
		/// <summary>Identifier for the "Infinite Credits" cheat.</summary>
		evCheatInfiniteCredits,
		/// <summary>Identifier for the "Infinite Stasis" cheat.</summary>
		evCheatInfiniteStasis,
		/// <summary>Identifier for the "Infinite Power Nodes" cheat.</summary>
		evCheatInfinitePowerNodes,
	}





	/// <summary>Identifiers for all of the code caves injected into the game process' memory space,
	/// once the trainer gets attached to the game.</summary>
	public enum ECodeCave
	{
	}





	/// <summary>Identifiers for all variables injected into the game process' memory space,
	/// once the trainer gets attached to the game.</summary>
	public enum EVariable
	{
	}
}