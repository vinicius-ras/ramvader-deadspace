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
		/// <summary>Identifier for the "Unlimited Oxygen" cheat.</summary>
		evCheatUnlimitedOxygen,
	}





	/// <summary>Identifiers for all of the code caves injected into the game process' memory space,
	/// once the trainer gets attached to the game.</summary>
	public enum ECodeCave
	{
		/// <summary>Identifier for the code cave used for the "Infinite HP" cheat.</summary>
		[CodeCaveDefinition( 0x68, 0xAA, 0xAA, 0x00, 0x00, 0xDB, 0x04, 0x24, 0xD9, 0x98, 0x20, 0x01, 0x00, 0x00, 0x83, 0xC4, 0x04, 0x0F, 0x2F, 0x80, 0x20, 0x01, 0x00, 0x00, 0xC3 )]
		evCodeCaveInfiniteHP,
		/// <summary>Identifier for the code cave used for the "Infinite Ammo" cheat.</summary>
		[CodeCaveDefinition( 0x68, 0x9A, 0x02, 0x00, 0x00, 0x8F, 0x80, 0x84, 0x06, 0x00, 0x00, 0x8B, 0x88, 0x84, 0x06, 0x00, 0x00, 0xC3 )]
		evCodeCaveInfiniteAmmo,
		/// <summary>Identifier for the code cave used for the "Infinite Stasis" cheat.</summary>
		[CodeCaveDefinition( 0x68, 0xAA, 0xAA, 0x00, 0x00, 0xDB, 0x04, 0x24, 0xD9, 0x99, 0x28, 0x01, 0x00, 0x00, 0x83, 0xC4, 0x04, 0xF3, 0x0F, 0x10, 0x89, 0x28, 0x01, 0x00, 0x00, 0xC3 )]
		evCodeCaveInfiniteStasis,
		/// <summary>Identifier for the code cave used for the "Infinite Power Nodes" cheat.</summary>
		[CodeCaveDefinition( 0x68, 0x9A, 0x02, 0x00, 0x00, 0x8F, 0x81, 0x94, 0x05, 0x00, 0x00, 0x8B, 0x81, 0x94, 0x05, 0x00, 0x00, 0xC3 )]
		evCodeCaveInfinitePowerNodes,
		/// <summary>Identifier for the first code cave used for the "Infinite Credits" cheat.</summary>
		[CodeCaveDefinition( 0x68, 0x2A, 0x2C, 0x0A, 0x00, 0x8F, 0x82, 0xE4, 0x0C, 0x00, 0x00, 0x8B, 0x82, 0xE4, 0x0C, 0x00, 0x00, 0xC3 )]
		evCodeCaveInfiniteCredits1,
		/// <summary>Identifier for the second code cave used for the "Infinite Credits" cheat.</summary>
		[CodeCaveDefinition( 0x68, 0x2A, 0x2C, 0x0A, 0x00, 0x8F, 0x81, 0xE4, 0x0C, 0x00, 0x00, 0x8B, 0x81, 0xE4, 0x0C, 0x00, 0x00, 0xC3 )]
		evCodeCaveInfiniteCredits2,
	}





	/// <summary>Identifiers for all variables injected into the game process' memory space,
	/// once the trainer gets attached to the game.</summary>
	public enum EVariable
	{
	}
}