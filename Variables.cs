using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour {

	// Use this for initialization
	void Start () {

		//PrecisionCheck call
		//PrecisionCheck();

		// prints the min and the max int value
		//print(int.MaxValue);
		//print(int.MinValue);

		// prints the story to the console
		//TellMeAStory();
		//DemoOperators();
		TellMeAStoryDoneRight();
	}

	void DemoOperators() {

		bool trueValue = true;
		bool falseValue = false;
		int myInt = 35;
		string  myString = "This whole ZombBear Situation is getting out of hand!";

		print("trueValue == true: " + (trueValue == true));
		print("trueValue == false: " + (trueValue == false));
		print("falseValue == true: " + (falseValue == true));
		print("falseValue == false: " + (falseValue == false));
		print("myInt == 35: " + (myInt == 35));
		print("myString == YES: " + (myString == "YES"));
		print("myString.Equals(Ben's a hero!): " + myString.Equals("Ben's a hero!"));

		print("myInt > 50: " + (myInt > 50));
		print("myInt < 50: " + (myInt < 50));
		print("myInt >= 35: " + (myInt >= 35));
		print("myInt <= 35: " + (myInt <= 35));

		print("true && false: " + (trueValue && falseValue));
		print("true || false: " + (trueValue || falseValue));
		print("myInt > 50 && myInt < 50: " +(myInt > 50 && myInt < 50));
		print("myInt > 50 || myInt < 50: " +(myInt > 50 || myInt < 50));

	}

	void PrecisionCheck() {

		var myDouble = 0.0d;
		var myFloat = 0.0f;
		var myInt = 1;

		myDouble += myInt;
		myFloat += myInt;


	}
	
	void TellMeAStory() {

		// chaar variable example
		//char myChar = 'a';

		// Strinf variable example
		//string myString = "My first string!";

		//Boolean
		var myBool = true;		
		
		// exp variables
		var levelXp = 10;
		

		// The hero
		var heroName = "Lucas the Noob";
		var heroWeapon = "Foam Sword";
		var heroBattleCry = "Don't hurt me!";
		var heroXp = 0;
		var heroAlignmentPercent = 0.05f;
		var heroMovementSpeed = 1.05f;

		// prints the hero
		print("Hero Name: " + heroName);
		print("Hero Weapon: " + heroWeapon);
		print("Hero Battle Cry: " + heroBattleCry);
		print("Hero total XP: " + heroXp);
		print("Hero Alignment % " + heroAlignmentPercent);
		print("Hero Movement Speed: " + heroMovementSpeed);
		print("Hero Level: " + heroXp / levelXp);
		print("Hero Level XP: " +  heroXp % levelXp);

		var heroLevel = heroXp / levelXp;

		if (heroLevel <= 1) {
			print("I'm just not strong enough...");
		} else if (heroLevel <= 3) {
			print("I'm almost ready.");
		} else {
			print("I'm coming for you, Dr. Zombear.");
		}

		switch(heroLevel) {

			// This will fall through to case 1
			case 0:
			case 1:
				print("I'm just not strong enough...");
				break;
			case 2:
			case 3:
				print("I'm almost ready.");
				break;
			default:
				print("I'm coming for you, Dr. Zombear.");
				break;


		}

		// The villain
		var villainName = "Dr. ZomBear";
		var villainWeapon = "Nun-Chucks, but made out of teddy bears";
		var villainBattleCry = "My agent said this would be a big role...";
		villainBattleCry += " but this is gertting a little weird";
		var villainXp = 0;
		var villainAlignmentPercent = 0.0f;
		var villainMovementSpeed = 1.3f;
		var VillainIsEvil = false;

		// prints the villain
		print("Villain Name: " + villainName);
		print("Villain Weapon: " + villainWeapon);
		print("Villain Battle Cry: " + villainBattleCry);
		print("Villain total XP: " + villainXp);
		print("Villain Alignment % " + villainAlignmentPercent);
		print("Villain movement speed: " + villainMovementSpeed);
		print("Villain Level: " + villainXp / levelXp);
		print("Villain Level XP: " + villainXp % levelXp);
		print("Villain is Evil: " + VillainIsEvil);

		// makes the hero better
		heroName = heroName.Replace("Noob", "Minor Character from a one season indie film");
		heroWeapon = heroWeapon.Remove(0, 5);
		heroBattleCry = heroBattleCry.ToUpper();
		heroXp += 35;
		heroXp++;
		heroMovementSpeed -= 0.2f;
		heroAlignmentPercent *= 2;

		// Reprints the hero
		print("Hero Name: " + heroName);
		print("Hero Weapon: " + heroWeapon);
		print("Hero Battle Cry: " + heroBattleCry);
		print("Hero total XP: " + heroXp);
		print("Hero Alignment % " + heroAlignmentPercent);
		print("Hero Movement Speed: " + heroMovementSpeed);
		print("Hero Level: " + heroXp / levelXp);
		print("Hero Level XP: " +  heroXp % levelXp);

		// upgrades the villain
		villainWeapon = villainWeapon.Substring(0, 10);
		villainBattleCry = villainBattleCry.Insert(3, "lying ").Replace("but", "and");
		villainXp += 18;
		villainMovementSpeed += 0.1f;
		villainAlignmentPercent *= 1.5f;

		// Reprints the villian
		print("Villain Name: " + villainName);
		print("Villain Weapon: " + villainWeapon);
		print("Villain Battle Cry: " + villainBattleCry);
		print("Villain total XP: " + villainXp);
		print("Villain Alignment % " + villainAlignmentPercent);
		print("Villain movement speed: " + villainMovementSpeed);
		print("Villain Level: " + villainXp / levelXp);
		print("Villain Level XP: " + villainXp % levelXp);
		print("Villain is Evil: " + VillainIsEvil);

		VillainIsEvil = !VillainIsEvil;
		print("Is he reallt though? " + VillainIsEvil);
		
 
	} // End func

	void TellMeAStoryDoneRight() {

		
		// exp variables
		var levelXp = 10;
		

		// The hero
		var heroName = "Lucas the Noob";
		var heroWeapon = "Foam Sword";
		var heroBattleCry = "Don't hurt me!";
		var heroXp = 0;
		var heroAlignmentPercent = 0.05f;
		var heroMovementSpeed = 1.05f;

		var hero = new Character("Lucas the noob", "Foam Sword", "DON'T HURT ME", 0, 0.05f, 1.05f, true, 10);
		hero.PrintInfo();


		
		print(GetStatus(calculateLevel(heroXp, levelXp)));

		// The villain
		var villainName = "Dr. ZomBear";
		var villainWeapon = "Nun-Chucks, but made out of teddy bears";
		var villainBattleCry = "My agent said this would be a big role...";
		villainBattleCry += " but this is gertting a little weird";
		var villainXp = 0;
		var villainAlignmentPercent = 0.0f;
		var villainMovementSpeed = 1.3f;

		var villain = new Villain("Dr. ZomBear", "Nun-Chucks, but made out of teddy bears", "My agent said this would be a big role... but this is gertting a little weird", 0, 0.0f, 1.3f, false, 10, false);

		var VillainIsEvil = false;

		villain.PrintInfo();

		PrintInfo(true, "lucas the noob", "pool noodle", "I'm king of the kiddie pool", 10, 0, 0.0f, 1.0f);

	}

	void PrintInfo(bool isHero, string name, string weapon, string battleCry, int levelXp, int xp, float alignmentPercent, float movementSpeed) {

		string character = isHero ? "Hero" : "Villain";

		print(GetPrintStatement(character, "Name", name));
		print(GetPrintStatement(character, "Weapon", weapon));
		print(GetPrintStatement(character, "Battle Cry", battleCry));
		print(GetPrintStatement(character, "Total XP", xp.ToString()));
		print(GetPrintStatement(character, "Alignment %", alignmentPercent.ToString()));
		print(GetPrintStatement(character, "Movement Speed", movementSpeed.ToString()));
		print(GetPrintStatement(character, "Level", calculateLevel(xp, levelXp).ToString()));
		print(GetPrintStatement(character, "Level", calculateLevelXp(xp, levelXp).ToString()));

	}

	string GetPrintStatement(string character, string field, string value) {

		return string.Format("{0} {1}: {2}", character, field, value);

	}

	int calculateLevel(int xp, int levelXp) {

		return xp / levelXp;
	}

	int calculateLevelXp(int xp, int levelXp) {

		return xp % levelXp;
	}

	string GetStatus(int level) {

		switch(level) {

			// This will fall through to case 1
			case 0:
			case 1:
				return("I'm just not strong enough...");
			case 2:
			case 3:
				return("I'm almost ready.");
			default:
				return("I'm coming for you, Dr. Zombear.");

		}
	}

} // End class
