using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

class StoryBlock
{
    public string title;
    public string story;
    public string option1Text;
    public string option2Text;
    public string option3Text;
    public string option4Text;
    public StoryBlock option1Block;
    public StoryBlock option2Block;
    public StoryBlock option3Block;
    public StoryBlock option4Block;

    public StoryBlock(string title, string story, string option1Text = "- - -", string option2Text = "- - -", string option3Text = "- - -", string option4Text = "- - -", StoryBlock option1Block = null, StoryBlock option2Block = null, StoryBlock option3Block = null, StoryBlock option4Block = null)
    {
        this.title = title;
        this.story = story;
        this.option1Text = option1Text;
        this.option2Text = option2Text;
        this.option3Text = option3Text;
        this.option4Text = option4Text;
        this.option1Block = option1Block;
        this.option2Block = option2Block;
        this.option3Block = option3Block;
        this.option4Block = option4Block;
    }
}

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI title;
    public TextMeshProUGUI mainText;
    public Button option1;
    public Button option2;
    public Button option3;
    public Button option4;

    StoryBlock currentBlock;


    static StoryBlock theEnd = new StoryBlock("THE END", "Thank you for playing The Mist. This was my very first game that I worked on my own and I put alot of effort into making it. I hope you've enjoyed it. Since there isn't much to do here feel free and press the EXIT button to end the game. You can reopen the application if you want to play again.", "- - -", "- - -", "- - -", "- - -", intro1);
    static StoryBlock secretending = new StoryBlock("Congratz! You' chose the Alternate Ending!", "You figure you can’t do anything to stop the demons. You leave the dungeon, the altar, the church and…somehow you’re able to leave the town THE END", "Continue", "- - -", "- - -", "- - -", theEnd);



    //---ENDING--------------------------------
    static StoryBlock ending9 = new StoryBlock("THE END", "The End", "Continue", "- - -", "- - -", "- - -", theEnd);
    static StoryBlock ending8 = new StoryBlock("", "Hoping to find everyone, IF there is anyone left…", "Continue", "- - -", "- - -", "- - -", ending9);
    static StoryBlock ending7 = new StoryBlock("", "You open the church door and are met with a strong sunlight that almost blind you. You head out to find out what became of the town.", "Continue", "- - -", "- - -", "- - -", ending8);
    static StoryBlock ending6 = new StoryBlock("", "Still, no demons in sight. They are all gone.", "Continue", "- - -", "- - -", "- - -", ending7);
    static StoryBlock ending5 = new StoryBlock("", "You travel through the dungeon corridors, you pass through the construction site, you pass through the three-way fork. Eventually you make it back to the altar.", "Continue", "- - -", "- - -", "- - -", ending6);
    static StoryBlock ending4 = new StoryBlock("", "After you smashed the crystal everything cleared out. Looking towards where the demons went you find nothing. As if in an instant they were gone.", "Continue", "- - -", "- - -", "- - -", ending5);
    static StoryBlock ending3 = new StoryBlock("", "Your name is Ren. What seemed like a normal day to you turned out strange. Almost like you’re a protagonist from some kind of a survival horror video game.", "Continue", "- - -", "- - -", "- - -", ending4);
    static StoryBlock ending2 = new StoryBlock("", "... ...", "Continue", "- - -", "- - -", "- - -", ending3);
    static StoryBlock ending1 = new StoryBlock("", "...", "Continue", "- - -", "- - -", "- - -", ending2);



    //---CHURCH--------------------------------
    //---finale pathing--------------------------------
    static StoryBlock churchfinale8b = new StoryBlock("Chapter 5: The Church", "The demons, attracted by the light and noise, immediately flock into the hallway where you threw the flashlight. You immediately make your chance for the crystal.", "Smash crystal", "- - -", "- - -", "- - -", ending1);
    static StoryBlock churchfinale8a = new StoryBlock("GAME OVER", "You attempt to sneak attack the demons using the sledge hammer. You manage to knock out one but you’re outnumbered by the other demons GAME OVER", "Try again", "- - -", "- - -", "- - -", churchfinale8b);
    static StoryBlock churchfinale8 = new StoryBlock("Chapter 5: The Church", "Why leave now? Now’s your chance!", "Smash crystal", "Sneak attack", "- - -", "- - -", ending1, churchfinale8a);
    static StoryBlock churchfinale7b = new StoryBlock("Chapter 5: The Church", "Why leave now? Now’s your chance!", "Smash crystal", "- - -", "- - -", "- - -", ending1);
    static StoryBlock churchfinale7a = new StoryBlock("Chapter 5: The Church", "The demons, attracted by the light and noise, immediately flock into the hallway where you threw the flashlight. You immediately make your chance for the crystal.", "Leave", "Smash crystal", "- - -", "- - -", churchfinale7b, ending1);
    static StoryBlock churchfinale7 = new StoryBlock("GAME OVER", "You attempt to sneak attack the demons using the sledge hammer. You manage to knock out one but you’re outnumbered by the other demons GAME OVER", "Try again", "- - -", "- - -", "- - -", churchfinale7a);
    static StoryBlock churchfinale6 = new StoryBlock("Chapter 5: The Church", "The demons, attracted by the light and noise, immediately flock into the hallway where you threw the flashlight. You immediately make your chance for the crystal.", "Sneak attack", "Leave", "Smash crystal", "- - -", churchfinale7, churchfinale8, ending1);
    static StoryBlock churchfinale5 = new StoryBlock("Chapter 5: The Church", "You turn on the flashlight, and, before the demons can notice you, you throw it into the nearest hallway. It makes loud noises as it hits the ground", "Continue", "- - -", "- - -", "- - -", churchfinale6);
    static StoryBlock churchfinale4 = new StoryBlock("Chapter 5: The Church", "You need to distract the demons somehow so you figure the flashlight might be of some use. Up to this point the demons have been strangely attracted to light (well it’s about time!).", "Continue", "- - -", "- - -", "- - -", churchfinale5);
    static StoryBlock churchfinale3c = new StoryBlock("Chapter 5: The Church", "Unfortunately as you make it back the crystal has spawned many more demons to the point that they fill the room. You manage to hide yourself from them before they notice you. What do you do now?", "Leave", "Use flashlight", "- - -", "- - -", secretending, churchfinale4);
    static StoryBlock churchfinale3b = new StoryBlock("GAME OVER", "You attempt to fight the demons with the sledgehammer. But there’s too many of them so they easily outnumber you. And due to the sledgehammer being too heavy you aren’t very versatile enough to use it GAME OVER", "Try again", "- - -", "- - -", "- - -", churchfinale3c);
    static StoryBlock churchfinale3a = new StoryBlock("Chapter 5: The Church", "Unfortunately as you make it back the crystal has spawned many more demons to the point that they fill the room. You manage to hide yourself from them before they notice you. What do you do now?", "Use flashlight", "Fight the demons", "Leave", "- - -", churchfinale4, churchfinale3b, secretending);
    static StoryBlock churchfinale3 = new StoryBlock("GAME OVER", "…I…WHAT!", "Try again", "- - -", "- - -", "- - -", churchfinale3a);
    static StoryBlock churchfinale2b = new StoryBlock("Chapter 5: The Church", "…I…WHAT!", "Leave", "Use flashlight", "- - -", "- - -", secretending, churchfinale4);
    static StoryBlock churchfinale2a = new StoryBlock("Chapter 5: The Church", "Unfortunately as you make it back the crystal has spawned many more demons to the point that they fill the room. You manage to hide yourself from them before they notice you. What do you do now?", "Use flashlight", "Flirt", "Leave", "- - -", churchfinale4, churchfinale2b, secretending);
    static StoryBlock churchfinale2 = new StoryBlock("GAME OVER", "You attempt to fight the demons with the sledgehammer. But there’s too many of them so they easily outnumber you. And due to the sledgehammer being too heavy you aren’t very versatile enough to use it GAME OVER", "Try again", "- - -", "- - -", "- - -", churchfinale2a);
    static StoryBlock churchfinale1 = new StoryBlock("Chapter 5: The Church", "Unfortunately as you make it back the crystal has spawned many more demons to the point that they fill the room. You manage to hide yourself from them before they notice you. What do you do now?", "Use flashlight", "Fight the demons", "Leave", "Flirt", churchfinale4, churchfinale2, secretending, churchfinale3);
    static StoryBlock site5 = new StoryBlock("Chapter 5: The Church", "The sledgehammer is big and heavy enough to completely smash a crystal. This should do it! However, the sledgehammer proves to be too heavy that it forces you to drag it as you make it back to the crystal room.", "Continue", "- - -", "- - -", "- - -", churchfinale1);
    //---site pathing--------------------------------
    static StoryBlock site4bb = new StoryBlock("Chapter 5: The Church", "Last you checked saws can’t cut through rocks.", "Take sledgehammer", "- - -", "- - -", "- - -", site5);
    static StoryBlock site4aa = new StoryBlock("Chapter 5: The Church", "“This drill will pierce the Heavens but it won’t be enough to destroy the crystal.”", "Take sledgehammer", "- - -", "- - -", "- - -", site5);
    static StoryBlock site4b = new StoryBlock("Chapter 5: The Church", "“This drill will pierce the Heavens but it won’t be enough to destroy the crystal.”", "Take sledgehammer", "Take wrench", "- - -", "- - -", site5, site4bb);
    static StoryBlock site4a = new StoryBlock("Chapter 5: The Church", "Last you checked saws can’t cut through rocks.", "Take drill", "Take sledgehammer", "- - -", "- - -", site4aa, site5);
    static StoryBlock site4 = new StoryBlock("Chapter 5: The Church", "It’s slightly heavy, but not strong enough to smash a crystal", "Take saw", "Take sledgehammer", "Take drill", "- - -", site4a, site5, site4b);
    static StoryBlock site3bb = new StoryBlock("Chapter 5: The Church", "It’s slightly heavy, but not strong enough to smash a crystal", "Take sledgehammer", "- - -", "- - -", "- - -", site5);
    static StoryBlock site3aa = new StoryBlock("Chapter 5: The Church", "“This drill will pierce the Heavens but it won’t be enough to destroy the crystal.”", "Take sledgehammer", "- - -", "- - -", "- - -", site5);
    static StoryBlock site3b = new StoryBlock("Chapter 5: The Church", "“This drill will pierce the Heavens but it won’t be enough to destroy the crystal.”", "Take sledgehammer", "Take wrench", "- - -", "- - -", site5, site3bb);
    static StoryBlock site3a = new StoryBlock("Chapter 5: The Church", "It’s slightly heavy, but not strong enough to smash a crystal", "Take drill", "Take sledgehammer", "- - -", "- - -", site3aa, site5);
    static StoryBlock site3 = new StoryBlock("Chapter 5: The Church", "Last you checked saws can’t cut through rocks.", "Take wrench", "Take sledgehammer", "Take drill", "- - -", site3a, site5, site3b);
    static StoryBlock site2bb = new StoryBlock("Chapter 5: The Church", "It’s slightly heavy, but not strong enough to smash a crystal", "Take sledgehammer", "- - -", "- - -", "- - -", site5);
    static StoryBlock site2aa = new StoryBlock("Chapter 5: The Church", "Last you checked saws can’t cut through rocks.", "Take sledgehammer", "- - -", "- - -", "- - -", site5);
    static StoryBlock site2b = new StoryBlock("Chapter 5: The Church", "Last you checked saws can’t cut through rocks.", "Take sledgehammer", "Take wrench", "- - -", "- - -", site5, site2bb);
    static StoryBlock site2a = new StoryBlock("Chapter 5: The Church", "It’s slightly heavy, but not strong enough to smash a crystal", "Take saw", "Take sledgehammer", "- - -", "- - -", site2aa, site5);
    static StoryBlock site2 = new StoryBlock("Chapter 5: The Church", "“This drill will pierce the Heavens but it won’t be enough to destroy the crystal.”", "Take wrench", "Take sledgehammer", "Take saw", "- - -", site2a, site5, site2b);
    static StoryBlock site1 = new StoryBlock("Chapter 5: The Church", "You remove the tarp. You find a vast selection of tools in front of you: A wrench, an electric drill, a sledgehammer, and a saw.", "Take drill", "Take saw", "Take sledgehammer", "Take wrench", site2, site3, site5, site4);
    static StoryBlock church15a = new StoryBlock("Chapter 5: The Church", "“I can’t find anything with that tarp covering everything”", "Remove tarp", "- - -", "- - -", "- - -", site1);
    static StoryBlock church15 = new StoryBlock("Chapter 5: The Church", "You return back to the construction site. It looks like they were renovating here but due to the invasion it’s left unfinished. Most of the site is covered in tarps.", "Look for tools", "Remove tarp", "- - -", "- - -", church15a, site1);
    static StoryBlock church14 = new StoryBlock("Chapter 5: The Church", "You remember that while wandering the dungeon you came across a construction site. You should probably check that out to find something strong enough to smash the crystal.", "Go to construction site", "- - -", "- - -", "- - -", church15);
    static StoryBlock church13 = new StoryBlock("Chapter 5: The Church", "You attempt to kick the crystal, but it’s embedded hard onto the ground and you stub your toe doing it. You figure you’ll need something stronger to destroy it.", "Continue", "- - -", "- - -", "- - -", church14);
    //---crystal pathing--------------------------------
    static StoryBlock crystal3bb = new StoryBlock("Chapter 5: The Church", "You attempt to take the crystal, but it’s embedded hard onto the ground. It’s also hot so you almost burn your fingers.", "Destroy crystal", "- - -", "- - -", "- - -", church13);
    static StoryBlock crystal3aa = new StoryBlock("Chapter 5: The Church", "You left the jewel at the candelabra", "Destroy crystal", "- - -", "- - -", "- - -", church13);
    static StoryBlock crystal3b = new StoryBlock("Chapter 5: The Church", "You left the jewel at the candelabra", "Take crystal", "Destroy crystal", "- - -", "- - -", crystal3bb, church13);
    static StoryBlock crystal3a = new StoryBlock("Chapter 5: The Church", "You attempt to take the crystal, but it’s embedded hard onto the ground. It’s also hot so you almost burn your fingers.", "Destroy crystal", "Use jewel", "- - -", "- - -", church13, crystal3aa);
    static StoryBlock crystal3 = new StoryBlock("Chapter 5: The Church", "You attempt to ask the crystal to stop the demonic invasion, but it doesn’t say anything. Rocks don’t talk, dummy!", "Take crystal", "Destroy crystal", "Use jewel", "- - -", crystal3a, church13, crystal3b);
    static StoryBlock crystal2bb = new StoryBlock("Chapter 5: The Church", "You attempt to take the crystal, but it’s embedded hard onto the ground. It’s also hot so you almost burn your fingers.", "Destroy crystal", "- - -", "- - -", "- - -", church13);
    static StoryBlock crystal2aa = new StoryBlock("Chapter 5: The Church", "You attempt to ask the crystal to stop the demonic invasion, but it doesn’t say anything. Rocks don’t talk, dummy!", "Destroy crystal", "- - -", "- - -", "- - -", church13);
    static StoryBlock crystal2b = new StoryBlock("Chapter 5: The Church", "You attempt to ask the crystal to stop the demonic invasion, but it doesn’t say anything. Rocks don’t talk, dummy!", "Take crystal", "Destroy crystal", "- - -", "- - -", crystal2bb, church13);
    static StoryBlock crystal2a = new StoryBlock("Chapter 5: The Church", "You attempt to take the crystal, but it’s embedded hard onto the ground. It’s also hot so you almost burn your fingers.", "Destroy crystal", "Talk to the crystal", "- - -", "- - -", church13, crystal2aa);
    static StoryBlock crystal2 = new StoryBlock("Chapter 5: The Church", "You left the jewel at the candelabra", "Take crystal", "Destroy crystal", "Talk to the crystal", "- - -", crystal2a, church13, crystal2b);
    static StoryBlock crystal1bb = new StoryBlock("Chapter 5: The Church", "You left the jewel at the candelabra", "Destroy crystal", "- - -", "- - -", "- - -", church13);
    static StoryBlock crystal1aa = new StoryBlock("Chapter 5: The Church", "You attempt to ask the crystal to stop the demonic invasion, but it doesn’t say anything. Rocks don’t talk, dummy!", "Destroy crystal", "- - -", "- - -", "- - -", church13);
    static StoryBlock crystal1b = new StoryBlock("Chapter 5: The Church", "You attempt to ask the crystal to stop the demonic invasion, but it doesn’t say anything. Rocks don’t talk, dummy!", "Use jewel", "Destroy crystal", "- - -", "- - -", crystal1bb, church13);
    static StoryBlock crystal1a = new StoryBlock("Chapter 5: The Church", "You left the jewel at the candelabra", "Destroy crystal", "Talk to the crystal", "- - -", "- - -", church13, crystal1aa);
    static StoryBlock crystal1 = new StoryBlock("Chapter 5: The Church", "You attempt to take the crystal, but it’s embedded hard onto the ground. It’s also hot so you almost burn your fingers.", "Use jewel", "Destroy crystal", "Talk to the crystal", "- - -", crystal1a, church13, crystal1b);
    static StoryBlock church12 = new StoryBlock("Chapter 5: The Church", "The crystal has a dim light but you notice it’s releasing a thin layer of mist. This must be the source of the demonic invasion.", "Take crystal", "Destroy crystal", "Use jewel", "Talk to the crystal", crystal1, church13, crystal2, crystal3);
    static StoryBlock church11 = new StoryBlock("Chapter 5: The Church", "After walking for a while you end up in an empty room. In the middle of the room is a strange glowing crystal.", "Check crystal", "- - -", "- - -", "- - -", church12);
    static StoryBlock corridorR = new StoryBlock("Chapter 5: The Church", "You take the right corridor. This corridor feels safer to take.", "Continue", "- - -", "- - -", "- - -", church11);
    //---corridorC pathing--------------------------------
    static StoryBlock corridorC2 = new StoryBlock("Chapter 5: The Church", "You wander carefully through the dark dungeon corridors. The mist is a lot thicker than before here so you know that there might be more demons lurking around. Eventually you make it to a three-way fork.", "Take the right corridor", "- - -", "- - -", "- - -", corridorR);
    static StoryBlock corridorC1 = new StoryBlock("GAME OVER", "You take the left corridor. Unbeknownst to you there is a trap door. You step on it and fall GAME OVER", "Try again", "- - -", "- - -", "- - -", corridorC2);
    static StoryBlock rewind2 = new StoryBlock("Chapter 5: The Church", "You wander carefully through the dark dungeon corridors. The mist is a lot thicker than before here so you know that there might be more demons lurking around. Eventually you make it to a three-way fork.", "Take the left corridor", "Take the right corridor", "- - -", "- - -", corridorC1, corridorR);
    static StoryBlock deadend2 = new StoryBlock("Uh-oh", "Looks like you've met a dead end. Let's go back!", "It's rewind time!", "- - -", "- - -", "- - -", rewind2);
    static StoryBlock corridorCdend6 = new StoryBlock("GAME OVER", "You stand still. Unfortunately you stand too close to the demon so it notices you immediately. It attacks you GAME OVER", "Try again", "- - -", "- - -", "- - -", deadend2);
    static StoryBlock corridorCdend5 = new StoryBlock("GAME OVER", "You use the flashlight. The demon growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", deadend2);
    static StoryBlock corridorCdend4 = new StoryBlock("GAME OVER", "You stand still. Unfortunately you stand too close to the demon so it notices you immediately. It attacks you GAME OVER", "Try again", "- - -", "- - -", "- - -", deadend2);
    static StoryBlock corridorCdend3 = new StoryBlock("GAME OVER", "You attempt to fight the demon but the demon proves to be too powerful. The demon growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", deadend2);
    static StoryBlock corridorCdend2 = new StoryBlock("GAME OVER", "You use the flashlight. The demon growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", deadend2);
    static StoryBlock corridorCdend1 = new StoryBlock("GAME OVER", "You attempt to fight the demon but the demon proves to be too powerful. The demon growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", deadend2);
    static StoryBlock corridorCdfinal6 = new StoryBlock("Chapter 5: The Church", "You take the center corridor. You’re immediately met by a demon.", "Stand still", "- - -", "- - -", "- - -", corridorCdend6);
    static StoryBlock corridorCdfinal5 = new StoryBlock("Chapter 5: The Church", "You take the center corridor. You’re immediately met by a demon.", "Use flashlight", "- - -", "- - -", "- - -", corridorCdend5);
    static StoryBlock corridorCdfinal4 = new StoryBlock("Chapter 5: The Church", "You take the center corridor. You’re immediately met by a demon.", "Stand still", "- - -", "- - -", "- - -", corridorCdend4);
    static StoryBlock corridorCdfinal3 = new StoryBlock("Chapter 5: The Church", "You take the center corridor. You’re immediately met by a demon.", "Fight", "- - -", "- - -", "- - -", corridorCdend3);
    static StoryBlock corridorCdfinal2 = new StoryBlock("Chapter 5: The Church", "You take the center corridor. You’re immediately met by a demon.", "Use flashlight", "- - -", "- - -", "- - -", corridorCdend2);
    static StoryBlock corridorCdfinal1 = new StoryBlock("Chapter 5: The Church", "You take the center corridor. You’re immediately met by a demon.", "Fight", "- - -", "- - -", "- - -", corridorCdend1);
    static StoryBlock corridorCdccb = new StoryBlock("GAME OVER", "You use the flashlight. The demon growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", corridorCdfinal6);
    static StoryBlock corridorCdcca = new StoryBlock("GAME OVER", "You stand still. Unfortunately you stand too close to the demon so it notices you immediately. It attacks you GAME OVER", "Try again", "- - -", "- - -", "- - -", corridorCdfinal5);
    static StoryBlock corridorCdbbc = new StoryBlock("GAME OVER", "You attempt to fight the demon but the demon proves to be too powerful. The demon growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", corridorCdfinal4);
    static StoryBlock corridorCdbba = new StoryBlock("GAME OVER", "You stand still. Unfortunately you stand too close to the demon so it notices you immediately. It attacks you GAME OVER", "Try again", "- - -", "- - -", "- - -", corridorCdfinal3);
    static StoryBlock corridorCdaac = new StoryBlock("GAME OVER", "You attempt to fight the demon but the demon proves to be too powerful. The demon growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", corridorCdfinal2);
    static StoryBlock corridorCdaab = new StoryBlock("GAME OVER", "You use the flashlight. The demon growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", corridorCdfinal1);
    static StoryBlock corridorCdcc = new StoryBlock("Chapter 5: The Church", "You take the center corridor. You’re immediately met by a demon.", "Stand still", "Use flashlight", "- - -", "- - -", corridorCdcca, corridorCdccb);
    static StoryBlock corridorCdbb = new StoryBlock("Chapter 5: The Church", "You take the center corridor. You’re immediately met by a demon.", "Stand still", "Fight", "- - -", "- - -", corridorCdbba, corridorCdbbc);
    static StoryBlock corridorCdaa = new StoryBlock("Chapter 5: The Church", "You take the center corridor. You’re immediately met by a demon.", "Use flashlight", "Fight", "- - -", "- - -", corridorCdaab, corridorCdaac);
    static StoryBlock corridorCdc = new StoryBlock("GAME OVER", "You attempt to fight the demon but the demon proves to be too powerful. The demon growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", corridorCdcc);
    static StoryBlock corridorCdb = new StoryBlock("GAME OVER", "You use the flashlight. The demon growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", corridorCdbb);
    static StoryBlock corridorCda = new StoryBlock("GAME OVER", "You stand still. Unfortunately you stand too close to the demon so it notices you immediately. It attacks you GAME OVER", "Try again", "- - -", "- - -", "- - -", corridorCdaa);
    static StoryBlock corridorCdd = new StoryBlock("Chapter 5: The Church", "You take the center corridor. You’re immediately met by a demon.", "Stand still", "Use flashlight", "Fight", "- - -", corridorCda, corridorCdb, corridorCdc);
    static StoryBlock corridorCd = new StoryBlock("GAME OVER", "You attempt to make your way back. The demon notices you and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", corridorCdd);
    static StoryBlock corridorCcend6 = new StoryBlock("GAME OVER", "You stand still. Unfortunately you stand too close to the demon so it notices you immediately. It attacks you GAME OVER", "Try again", "- - -", "- - -", "- - -", deadend2);
    static StoryBlock corridorCcend5 = new StoryBlock("GAME OVER", "You use the flashlight. The demon growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", deadend2);
    static StoryBlock corridorCcend4 = new StoryBlock("GAME OVER", "You stand still. Unfortunately you stand too close to the demon so it notices you immediately. It attacks you GAME OVER", "Try again", "- - -", "- - -", "- - -", deadend2);
    static StoryBlock corridorCcend3 = new StoryBlock("GAME OVER", "You attempt to make your way back. The demon notices you and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", deadend2);
    static StoryBlock corridorCcend2 = new StoryBlock("GAME OVER", "You use the flashlight. The demon growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", deadend2);
    static StoryBlock corridorCcend1 = new StoryBlock("GAME OVER", "You attempt to make your way back. The demon notices you and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", deadend2);
    static StoryBlock corridorCcfinal6 = new StoryBlock("Chapter 5: The Church", "You take the center corridor. You’re immediately met by a demon.", "Stand still", "- - -", "- - -", "- - -", corridorCcend6);
    static StoryBlock corridorCcfinal5 = new StoryBlock("Chapter 5: The Church", "You take the center corridor. You’re immediately met by a demon.", "Use flashlight", "- - -", "- - -", "- - -", corridorCcend5);
    static StoryBlock corridorCcfinal4 = new StoryBlock("Chapter 5: The Church", "You take the center corridor. You’re immediately met by a demon.", "Stand still", "- - -", "- - -", "- - -", corridorCcend4);
    static StoryBlock corridorCcfinal3 = new StoryBlock("Chapter 5: The Church", "You take the center corridor. You’re immediately met by a demon.", "Turn back", "- - -", "- - -", "- - -", corridorCcend3);
    static StoryBlock corridorCcfinal2 = new StoryBlock("Chapter 5: The Church", "You take the center corridor. You’re immediately met by a demon.", "Use flashlight", "- - -", "- - -", "- - -", corridorCcend2);
    static StoryBlock corridorCcfinal1 = new StoryBlock("Chapter 5: The Church", "You take the center corridor. You’re immediately met by a demon.", "Turn back", "- - -", "- - -", "- - -", corridorCcend1);
    static StoryBlock corridorCcddb = new StoryBlock("GAME OVER", "You use the flashlight. The demon growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", corridorCcfinal6);
    static StoryBlock corridorCcdda = new StoryBlock("GAME OVER", "You stand still. Unfortunately you stand too close to the demon so it notices you immediately. It attacks you GAME OVER", "Try again", "- - -", "- - -", "- - -", corridorCcfinal5);
    static StoryBlock corridorCcbbc = new StoryBlock("GAME OVER", "You attempt to make your way back. The demon notices you and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", corridorCcfinal4);
    static StoryBlock corridorCcbba = new StoryBlock("GAME OVER", "You stand still. Unfortunately you stand too close to the demon so it notices you immediately. It attacks you GAME OVER", "Try again", "- - -", "- - -", "- - -", corridorCcfinal3);
    static StoryBlock corridorCcaac = new StoryBlock("GAME OVER", "You attempt to make your way back. The demon notices you and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", corridorCcfinal2);
    static StoryBlock corridorCcaab = new StoryBlock("GAME OVER", "You use the flashlight. The demon growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", corridorCcfinal1);
    static StoryBlock corridorCcdd = new StoryBlock("Chapter 5: The Church", "You take the center corridor. You’re immediately met by a demon.", "Stand still", "Use flashlight", "- - -", "- - -", corridorCcdda, corridorCcddb);
    static StoryBlock corridorCcbb = new StoryBlock("Chapter 5: The Church", "You take the center corridor. You’re immediately met by a demon.", "Stand still", "Turn back", "- - -", "- - -", corridorCcbba, corridorCcbbc);
    static StoryBlock corridorCcaa = new StoryBlock("Chapter 5: The Church", "You take the center corridor. You’re immediately met by a demon.", "Use flashlight", "Turn back", "- - -", "- - -", corridorCcaab, corridorCcaac);
    static StoryBlock corridorCcd = new StoryBlock("GAME OVER", "You attempt to make your way back. The demon notices you and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", corridorCcdd);
    static StoryBlock corridorCcb = new StoryBlock("GAME OVER", "You use the flashlight. The demon growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", corridorCcbb);
    static StoryBlock corridorCca = new StoryBlock("GAME OVER", "You stand still. Unfortunately you stand too close to the demon so it notices you immediately. It attacks you GAME OVER", "Try again", "- - -", "- - -", "- - -", corridorCcaa);
    static StoryBlock corridorCcc = new StoryBlock("Chapter 5: The Church", "You take the center corridor. You’re immediately met by a demon.", "Stand still", "Use flashlight", "Turn back", "- - -", corridorCca, corridorCcb, corridorCcd);
    static StoryBlock corridorCc = new StoryBlock("GAME OVER", "You attempt to fight the demon but the demon proves to be too powerful. The demon growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", corridorCcc);
    static StoryBlock corridorCbend6 = new StoryBlock("GAME OVER", "You stand still. Unfortunately you stand too close to the demon so it notices you immediately. It attacks you GAME OVER", "Try again", "- - -", "- - -", "- - -", deadend2);
    static StoryBlock corridorCbend5 = new StoryBlock("GAME OVER", "You attempt to fight the demon but the demon proves to be too powerful. The demon growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", deadend2);
    static StoryBlock corridorCbend4 = new StoryBlock("GAME OVER", "You stand still. Unfortunately you stand too close to the demon so it notices you immediately. It attacks you GAME OVER", "Try again", "- - -", "- - -", "- - -", deadend2);
    static StoryBlock corridorCbend3 = new StoryBlock("GAME OVER", "You attempt to make your way back. The demon notices you and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", deadend2);
    static StoryBlock corridorCbend2 = new StoryBlock("GAME OVER", "You attempt to fight the demon but the demon proves to be too powerful. The demon growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", deadend2);
    static StoryBlock corridorCbend1 = new StoryBlock("GAME OVER", "You attempt to make your way back. The demon notices you and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", deadend2);
    static StoryBlock corridorCbfinal6 = new StoryBlock("Chapter 5: The Church", "You take the center corridor. You’re immediately met by a demon.", "Stand still", "- - -", "- - -", "- - -", corridorCbend6);
    static StoryBlock corridorCbfinal5 = new StoryBlock("Chapter 5: The Church", "You take the center corridor. You’re immediately met by a demon.", "Fight", "- - -", "- - -", "- - -", corridorCbend5);
    static StoryBlock corridorCbfinal4 = new StoryBlock("Chapter 5: The Church", "You take the center corridor. You’re immediately met by a demon.", "Stand still", "- - -", "- - -", "- - -", corridorCbend4);
    static StoryBlock corridorCbfinal3 = new StoryBlock("Chapter 5: The Church", "You take the center corridor. You’re immediately met by a demon.", "Turn back", "- - -", "- - -", "- - -", corridorCbend3);
    static StoryBlock corridorCbfinal2 = new StoryBlock("Chapter 5: The Church", "You take the center corridor. You’re immediately met by a demon.", "Fight", "- - -", "- - -", "- - -", corridorCbend2);
    static StoryBlock corridorCbfinal1 = new StoryBlock("Chapter 5: The Church", "You take the center corridor. You’re immediately met by a demon.", "Turn back", "- - -", "- - -", "- - -", corridorCbend1);
    static StoryBlock corridorCbddb = new StoryBlock("GAME OVER", "You attempt to fight the demon but the demon proves to be too powerful. The demon growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", corridorCbfinal6);
    static StoryBlock corridorCbdda = new StoryBlock("GAME OVER", "You stand still. Unfortunately you stand too close to the demon so it notices you immediately. It attacks you GAME OVER", "Try again", "- - -", "- - -", "- - -", corridorCbfinal5);
    static StoryBlock corridorCbccb = new StoryBlock("GAME OVER", "You attempt to make your way back. The demon notices you and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", corridorCbfinal4);
    static StoryBlock corridorCbcca = new StoryBlock("GAME OVER", "You stand still. Unfortunately you stand too close to the demon so it notices you immediately. It attacks you GAME OVER", "Try again", "- - -", "- - -", "- - -", corridorCbfinal3);
    static StoryBlock corridorCbaac = new StoryBlock("GAME OVER", "You attempt to make your way back. The demon notices you and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", corridorCbfinal2);
    static StoryBlock corridorCbaab = new StoryBlock("GAME OVER", "You attempt to fight the demon but the demon proves to be too powerful. The demon growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", corridorCbfinal1);
    static StoryBlock corridorCbdd = new StoryBlock("Chapter 5: The Church", "You take the center corridor. You’re immediately met by a demon.", "Stand still", "Fight", "- - -", "- - -", corridorCbdda, corridorCbddb);
    static StoryBlock corridorCbcc = new StoryBlock("Chapter 5: The Church", "You take the center corridor. You’re immediately met by a demon.", "Stand still", "Turn back", "- - -", "- - -", corridorCbcca, corridorCbccb);
    static StoryBlock corridorCbaa = new StoryBlock("Chapter 5: The Church", "You take the center corridor. You’re immediately met by a demon.", "Fight", "Turn back", "- - -", "- - -", corridorCbaab, corridorCbaac);
    static StoryBlock corridorCbd = new StoryBlock("GAME OVER", "You attempt to make your way back. The demon notices you and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", corridorCbdd);
    static StoryBlock corridorCbc = new StoryBlock("GAME OVER", "You attempt to fight the demon but the demon proves to be too powerful. The demon growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", corridorCbcc);
    static StoryBlock corridorCba = new StoryBlock("GAME OVER", "You stand still. Unfortunately you stand too close to the demon so it notices you immediately. It attacks you GAME OVER", "Try again", "- - -", "- - -", "- - -", corridorCbaa);
    static StoryBlock corridorCbb = new StoryBlock("Chapter 5: The Church", "You take the center corridor. You’re immediately met by a demon.", "Stand still", "Fight", "Turn back", "- - -", corridorCba, corridorCbc, corridorCbd);
    static StoryBlock corridorCb = new StoryBlock("GAME OVER", "You use the flashlight. The demon growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", corridorCbb);
    static StoryBlock corridorCaend6 = new StoryBlock("GAME OVER", "You use the flashlight. The demon growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", deadend2);
    static StoryBlock corridorCaend5 = new StoryBlock("GAME OVER", "You attempt to fight the demon but the demon proves to be too powerful. The demon growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", deadend2);
    static StoryBlock corridorCaend4 = new StoryBlock("GAME OVER", "You use the flashlight. The demon growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", deadend2);
    static StoryBlock corridorCaend3 = new StoryBlock("GAME OVER", "You attempt to make your way back. The demon notices you and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", deadend2);
    static StoryBlock corridorCaend2 = new StoryBlock("GAME OVER", "You attempt to fight the demon but the demon proves to be too powerful. The demon growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", deadend2);
    static StoryBlock corridorCaend1 = new StoryBlock("GAME OVER", "You attempt to make your way back. The demon notices you and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", deadend2);
    static StoryBlock corridorCafinal6 = new StoryBlock("Chapter 5: The Church", "You take the center corridor. You’re immediately met by a demon.", "Use flashlight", "- - -", "- - -", "- - -", corridorCaend6);
    static StoryBlock corridorCafinal5 = new StoryBlock("Chapter 5: The Church", "You take the center corridor. You’re immediately met by a demon.", "Fight", "- - -", "- - -", "- - -", corridorCaend5);
    static StoryBlock corridorCafinal4 = new StoryBlock("Chapter 5: The Church", "You take the center corridor. You’re immediately met by a demon.", "Use flashlight", "- - -", "- - -", "- - -", corridorCaend4);
    static StoryBlock corridorCafinal3 = new StoryBlock("Chapter 5: The Church", "You take the center corridor. You’re immediately met by a demon.", "Turn back", "- - -", "- - -", "- - -", corridorCaend3);
    static StoryBlock corridorCafinal2 = new StoryBlock("Chapter 5: The Church", "You take the center corridor. You’re immediately met by a demon.", "Fight", "- - -", "- - -", "- - -", corridorCaend2);
    static StoryBlock corridorCafinal1 = new StoryBlock("Chapter 5: The Church", "You take the center corridor. You’re immediately met by a demon.", "Turn back", "- - -", "- - -", "- - -", corridorCaend1);
    static StoryBlock corridorCaddb = new StoryBlock("GAME OVER", "You attempt to fight the demon but the demon proves to be too powerful. The demon growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", corridorCafinal6);
    static StoryBlock corridorCadda = new StoryBlock("GAME OVER", "You use the flashlight. The demon growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", corridorCafinal5);
    static StoryBlock corridorCaccb = new StoryBlock("GAME OVER", "You attempt to make your way back. The demon notices you and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", corridorCafinal4);
    static StoryBlock corridorCacca = new StoryBlock("GAME OVER", "You use the flashlight. The demon growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", corridorCafinal3);
    static StoryBlock corridorCabbc = new StoryBlock("GAME OVER", "You attempt to make your way back. The demon notices you and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", corridorCafinal2);
    static StoryBlock corridorCabba = new StoryBlock("GAME OVER", "You attempt to fight the demon but the demon proves to be too powerful. The demon growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", corridorCafinal1);
    static StoryBlock corridorCadd = new StoryBlock("Chapter 5: The Church", "You take the center corridor. You’re immediately met by a demon.", "Use flashlight", "Fight", "- - -", "- - -", corridorCadda, corridorCaddb);
    static StoryBlock corridorCacc = new StoryBlock("Chapter 5: The Church", "You take the center corridor. You’re immediately met by a demon.", "Use flashlight", "Turn back", "- - -", "- - -", corridorCacca, corridorCaccb);
    static StoryBlock corridorCabb = new StoryBlock("Chapter 5: The Church", "You take the center corridor. You’re immediately met by a demon.", "Fight", "Turn back", "- - -", "- - -", corridorCabba, corridorCabbc);
    static StoryBlock corridorCad = new StoryBlock("GAME OVER", "You attempt to make your way back. The demon notices you and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", corridorCadd);
    static StoryBlock corridorCac = new StoryBlock("GAME OVER", "You attempt to fight the demon but the demon proves to be too powerful. The demon growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", corridorCacc);
    static StoryBlock corridorCab = new StoryBlock("GAME OVER", "You use the flashlight. The demon growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", corridorCabb);
    static StoryBlock corridorCaa = new StoryBlock("Chapter 5: The Church", "You take the center corridor. You’re immediately met by a demon.", "Use flashlight", "Fight", "Turn back", "- - -", corridorCab, corridorCac, corridorCad);
    static StoryBlock corridorCa = new StoryBlock("GAME OVER", "You stand still. Unfortunately you stand too close to the demon so it notices you immediately. It attacks you GAME OVER", "Try again", "- - -", "- - -", "- - -", corridorCaa);
    static StoryBlock corridorC = new StoryBlock("Chapter 5: The Church", "You take the center corridor. You’re immediately met by a demon.", "Stand still", "Use flashlight", "Fight", "Turn back", corridorCa, corridorCb, corridorCc, corridorCd);
    //---CorridorL pathing--------------------------------
    static StoryBlock rewind1 = new StoryBlock("Chapter 5: The Church", "You wander carefully through the dark dungeon corridors. The mist is a lot thicker than before here so you know that there might be more demons lurking around. Eventually you make it to a three-way fork.", "Take the right corridor", "- - -", "- - -", "- - -", corridorR);
    static StoryBlock deadend1 = new StoryBlock("Uh-oh", "Looks like you've met a dead end. Let's go back!", "It's rewind time!", "- - -", "- - -", "- - -", rewind1);
    static StoryBlock corridorL2dend6 = new StoryBlock("GAME OVER", "You stand still. Unfortunately you stand too close to the demon so it notices you immediately. It attacks you GAME OVER", "Try again", "- - -", "- - -", "- - -", deadend1);
    static StoryBlock corridorL2dend5 = new StoryBlock("GAME OVER", "You use the flashlight. The demon growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", deadend1);
    static StoryBlock corridorL2dend4 = new StoryBlock("GAME OVER", "You stand still. Unfortunately you stand too close to the demon so it notices you immediately. It attacks you GAME OVER", "Try again", "- - -", "- - -", "- - -", deadend1);
    static StoryBlock corridorL2dend3 = new StoryBlock("GAME OVER", "You attempt to fight the demon but the demon proves to be too powerful. The demon growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", deadend1);
    static StoryBlock corridorL2dend2 = new StoryBlock("GAME OVER", "You use the flashlight. The demon growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", deadend1);
    static StoryBlock corridorL2dend1 = new StoryBlock("GAME OVER", "You attempt to fight the demon but the demon proves to be too powerful. The demon growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", deadend1);
    static StoryBlock corridorL2dfinal6 = new StoryBlock("Chapter 5: The Church", "You take the center corridor. You’re immediately met by a demon.", "Stand still", "- - -", "- - -", "- - -", corridorL2dend6);
    static StoryBlock corridorL2dfinal5 = new StoryBlock("Chapter 5: The Church", "You take the center corridor. You’re immediately met by a demon.", "Use flashlight", "- - -", "- - -", "- - -", corridorL2dend5);
    static StoryBlock corridorL2dfinal4 = new StoryBlock("Chapter 5: The Church", "You take the center corridor. You’re immediately met by a demon.", "Stand still", "- - -", "- - -", "- - -", corridorL2dend4);
    static StoryBlock corridorL2dfinal3 = new StoryBlock("Chapter 5: The Church", "You take the center corridor. You’re immediately met by a demon.", "Fight", "- - -", "- - -", "- - -", corridorL2dend3);
    static StoryBlock corridorL2dfinal2 = new StoryBlock("Chapter 5: The Church", "You take the center corridor. You’re immediately met by a demon.", "Use flashlight", "- - -", "- - -", "- - -", corridorL2dend2);
    static StoryBlock corridorL2dfinal1 = new StoryBlock("Chapter 5: The Church", "You take the center corridor. You’re immediately met by a demon.", "Fight", "- - -", "- - -", "- - -", corridorL2dend1);
    static StoryBlock corridorL2dccb = new StoryBlock("GAME OVER", "You use the flashlight. The demon growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", corridorL2dfinal6);
    static StoryBlock corridorL2dcca = new StoryBlock("GAME OVER", "You stand still. Unfortunately you stand too close to the demon so it notices you immediately. It attacks you GAME OVER", "Try again", "- - -", "- - -", "- - -", corridorL2dfinal5);
    static StoryBlock corridorL2dbbc = new StoryBlock("GAME OVER", "You attempt to fight the demon but the demon proves to be too powerful. The demon growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", corridorL2dfinal4);
    static StoryBlock corridorL2dbba = new StoryBlock("GAME OVER", "You stand still. Unfortunately you stand too close to the demon so it notices you immediately. It attacks you GAME OVER", "Try again", "- - -", "- - -", "- - -", corridorL2dfinal3);
    static StoryBlock corridorL2daac = new StoryBlock("GAME OVER", "You attempt to fight the demon but the demon proves to be too powerful. The demon growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", corridorL2dfinal2);
    static StoryBlock corridorL2daab = new StoryBlock("GAME OVER", "You use the flashlight. The demon growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", corridorL2dfinal1);
    static StoryBlock corridorL2dcc = new StoryBlock("Chapter 5: The Church", "You take the center corridor. You’re immediately met by a demon.", "Stand still", "Use flashlight", "- - -", "- - -", corridorL2dcca, corridorL2dccb);
    static StoryBlock corridorL2dbb = new StoryBlock("Chapter 5: The Church", "You take the center corridor. You’re immediately met by a demon.", "Stand still", "Fight", "- - -", "- - -", corridorL2dbba, corridorL2dbbc);
    static StoryBlock corridorL2daa = new StoryBlock("Chapter 5: The Church", "You take the center corridor. You’re immediately met by a demon.", "Use flashlight", "Fight", "- - -", "- - -", corridorL2daab, corridorL2daac);
    static StoryBlock corridorL2dc = new StoryBlock("GAME OVER", "You attempt to fight the demon but the demon proves to be too powerful. The demon growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", corridorL2dcc);
    static StoryBlock corridorL2db = new StoryBlock("GAME OVER", "You use the flashlight. The demon growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", corridorL2dbb);
    static StoryBlock corridorL2da = new StoryBlock("GAME OVER", "You stand still. Unfortunately you stand too close to the demon so it notices you immediately. It attacks you GAME OVER", "Try again", "- - -", "- - -", "- - -", corridorL2daa);
    static StoryBlock corridorL2dd = new StoryBlock("Chapter 5: The Church", "You take the center corridor. You’re immediately met by a demon.", "Stand still", "Use flashlight", "Fight", "- - -", corridorL2da, corridorL2db, corridorL2dc);
    static StoryBlock corridorL2d = new StoryBlock("GAME OVER", "You attempt to make your way back. The demon notices you and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", corridorL2dd);
    static StoryBlock corridorL2cend6 = new StoryBlock("GAME OVER", "You stand still. Unfortunately you stand too close to the demon so it notices you immediately. It attacks you GAME OVER", "Try again", "- - -", "- - -", "- - -", deadend1);
    static StoryBlock corridorL2cend5 = new StoryBlock("GAME OVER", "You use the flashlight. The demon growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", deadend1);
    static StoryBlock corridorL2cend4 = new StoryBlock("GAME OVER", "You stand still. Unfortunately you stand too close to the demon so it notices you immediately. It attacks you GAME OVER", "Try again", "- - -", "- - -", "- - -", deadend1);
    static StoryBlock corridorL2cend3 = new StoryBlock("GAME OVER", "You attempt to make your way back. The demon notices you and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", deadend1);
    static StoryBlock corridorL2cend2 = new StoryBlock("GAME OVER", "You use the flashlight. The demon growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", deadend1);
    static StoryBlock corridorL2cend1 = new StoryBlock("GAME OVER", "You attempt to make your way back. The demon notices you and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", deadend1);
    static StoryBlock corridorL2cfinal6 = new StoryBlock("Chapter 5: The Church", "You take the center corridor. You’re immediately met by a demon.", "Stand still", "- - -", "- - -", "- - -", corridorL2cend6);
    static StoryBlock corridorL2cfinal5 = new StoryBlock("Chapter 5: The Church", "You take the center corridor. You’re immediately met by a demon.", "Use flashlight", "- - -", "- - -", "- - -", corridorL2cend5);
    static StoryBlock corridorL2cfinal4 = new StoryBlock("Chapter 5: The Church", "You take the center corridor. You’re immediately met by a demon.", "Stand still", "- - -", "- - -", "- - -", corridorL2cend4);
    static StoryBlock corridorL2cfinal3 = new StoryBlock("Chapter 5: The Church", "You take the center corridor. You’re immediately met by a demon.", "Turn back", "- - -", "- - -", "- - -", corridorL2cend3);
    static StoryBlock corridorL2cfinal2 = new StoryBlock("Chapter 5: The Church", "You take the center corridor. You’re immediately met by a demon.", "Use flashlight", "- - -", "- - -", "- - -", corridorL2cend2);
    static StoryBlock corridorL2cfinal1 = new StoryBlock("Chapter 5: The Church", "You take the center corridor. You’re immediately met by a demon.", "Turn back", "- - -", "- - -", "- - -", corridorL2cend1);
    static StoryBlock corridorL2cddb = new StoryBlock("GAME OVER", "You use the flashlight. The demon growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", corridorL2cfinal6);
    static StoryBlock corridorL2cdda = new StoryBlock("GAME OVER", "You stand still. Unfortunately you stand too close to the demon so it notices you immediately. It attacks you GAME OVER", "Try again", "- - -", "- - -", "- - -", corridorL2cfinal5);
    static StoryBlock corridorL2cbbc = new StoryBlock("GAME OVER", "You attempt to make your way back. The demon notices you and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", corridorL2cfinal4);
    static StoryBlock corridorL2cbba = new StoryBlock("GAME OVER", "You stand still. Unfortunately you stand too close to the demon so it notices you immediately. It attacks you GAME OVER", "Try again", "- - -", "- - -", "- - -", corridorL2cfinal3);
    static StoryBlock corridorL2caac = new StoryBlock("GAME OVER", "You attempt to make your way back. The demon notices you and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", corridorL2cfinal2);
    static StoryBlock corridorL2caab = new StoryBlock("GAME OVER", "You use the flashlight. The demon growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", corridorL2cfinal1);
    static StoryBlock corridorL2cdd = new StoryBlock("Chapter 5: The Church", "You take the center corridor. You’re immediately met by a demon.", "Stand still", "Use flashlight", "- - -", "- - -", corridorL2cdda, corridorL2cddb);
    static StoryBlock corridorL2cbb = new StoryBlock("Chapter 5: The Church", "You take the center corridor. You’re immediately met by a demon.", "Stand still", "Turn back", "- - -", "- - -", corridorL2cbba, corridorL2cbbc);
    static StoryBlock corridorL2caa = new StoryBlock("Chapter 5: The Church", "You take the center corridor. You’re immediately met by a demon.", "Use flashlight", "Turn back", "- - -", "- - -", corridorL2caab, corridorL2caac);
    static StoryBlock corridorL2cd = new StoryBlock("GAME OVER", "You attempt to make your way back. The demon notices you and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", corridorL2cdd);
    static StoryBlock corridorL2cb = new StoryBlock("GAME OVER", "You use the flashlight. The demon growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", corridorL2cbb);
    static StoryBlock corridorL2ca = new StoryBlock("GAME OVER", "You stand still. Unfortunately you stand too close to the demon so it notices you immediately. It attacks you GAME OVER", "Try again", "- - -", "- - -", "- - -", corridorL2caa);
    static StoryBlock corridorL2cc = new StoryBlock("Chapter 5: The Church", "You take the center corridor. You’re immediately met by a demon.", "Stand still", "Use flashlight", "Turn back", "- - -", corridorL2ca, corridorL2cb, corridorL2cd);
    static StoryBlock corridorL2c = new StoryBlock("GAME OVER", "You attempt to fight the demon but the demon proves to be too powerful. The demon growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", corridorL2cc);
    static StoryBlock corridorL2bend6 = new StoryBlock("GAME OVER", "You stand still. Unfortunately you stand too close to the demon so it notices you immediately. It attacks you GAME OVER", "Try again", "- - -", "- - -", "- - -", deadend1);
    static StoryBlock corridorL2bend5 = new StoryBlock("GAME OVER", "You attempt to fight the demon but the demon proves to be too powerful. The demon growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", deadend1);
    static StoryBlock corridorL2bend4 = new StoryBlock("GAME OVER", "You stand still. Unfortunately you stand too close to the demon so it notices you immediately. It attacks you GAME OVER", "Try again", "- - -", "- - -", "- - -", deadend1);
    static StoryBlock corridorL2bend3 = new StoryBlock("GAME OVER", "You attempt to make your way back. The demon notices you and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", deadend1);
    static StoryBlock corridorL2bend2 = new StoryBlock("GAME OVER", "You attempt to fight the demon but the demon proves to be too powerful. The demon growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", deadend1);
    static StoryBlock corridorL2bend1 = new StoryBlock("GAME OVER", "You attempt to make your way back. The demon notices you and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", deadend1);
    static StoryBlock corridorL2bfinal6 = new StoryBlock("Chapter 5: The Church", "You take the center corridor. You’re immediately met by a demon.", "Stand still", "- - -", "- - -", "- - -", corridorL2bend6);
    static StoryBlock corridorL2bfinal5 = new StoryBlock("Chapter 5: The Church", "You take the center corridor. You’re immediately met by a demon.", "Fight", "- - -", "- - -", "- - -", corridorL2bend5);
    static StoryBlock corridorL2bfinal4 = new StoryBlock("Chapter 5: The Church", "You take the center corridor. You’re immediately met by a demon.", "Stand still", "- - -", "- - -", "- - -", corridorL2bend4);
    static StoryBlock corridorL2bfinal3 = new StoryBlock("Chapter 5: The Church", "You take the center corridor. You’re immediately met by a demon.", "Turn back", "- - -", "- - -", "- - -", corridorL2bend3);
    static StoryBlock corridorL2bfinal2 = new StoryBlock("Chapter 5: The Church", "You take the center corridor. You’re immediately met by a demon.", "Fight", "- - -", "- - -", "- - -", corridorL2bend2);
    static StoryBlock corridorL2bfinal1 = new StoryBlock("Chapter 5: The Church", "You take the center corridor. You’re immediately met by a demon.", "Turn back", "- - -", "- - -", "- - -", corridorL2bend1);
    static StoryBlock corridorL2bddb = new StoryBlock("GAME OVER", "You attempt to fight the demon but the demon proves to be too powerful. The demon growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", corridorL2bfinal6);
    static StoryBlock corridorL2bdda = new StoryBlock("GAME OVER", "You stand still. Unfortunately you stand too close to the demon so it notices you immediately. It attacks you GAME OVER", "Try again", "- - -", "- - -", "- - -", corridorL2bfinal5);
    static StoryBlock corridorL2bccb = new StoryBlock("GAME OVER", "You attempt to make your way back. The demon notices you and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", corridorL2bfinal4);
    static StoryBlock corridorL2bcca = new StoryBlock("GAME OVER", "You stand still. Unfortunately you stand too close to the demon so it notices you immediately. It attacks you GAME OVER", "Try again", "- - -", "- - -", "- - -", corridorL2bfinal3);
    static StoryBlock corridorL2baac = new StoryBlock("GAME OVER", "You attempt to make your way back. The demon notices you and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", corridorL2bfinal2);
    static StoryBlock corridorL2baab = new StoryBlock("GAME OVER", "You attempt to fight the demon but the demon proves to be too powerful. The demon growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", corridorL2bfinal1);
    static StoryBlock corridorL2bdd = new StoryBlock("Chapter 5: The Church", "You take the center corridor. You’re immediately met by a demon.", "Stand still", "Fight", "- - -", "- - -", corridorL2bdda, corridorL2bddb);
    static StoryBlock corridorL2bcc = new StoryBlock("Chapter 5: The Church", "You take the center corridor. You’re immediately met by a demon.", "Stand still", "Turn back", "- - -", "- - -", corridorL2bcca, corridorL2bccb);
    static StoryBlock corridorL2baa = new StoryBlock("Chapter 5: The Church", "You take the center corridor. You’re immediately met by a demon.", "Fight", "Turn back", "- - -", "- - -", corridorL2baab, corridorL2baac);
    static StoryBlock corridorL2bd = new StoryBlock("GAME OVER", "You attempt to make your way back. The demon notices you and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", corridorL2bdd);
    static StoryBlock corridorL2bc = new StoryBlock("GAME OVER", "You attempt to fight the demon but the demon proves to be too powerful. The demon growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", corridorL2bcc);
    static StoryBlock corridorL2ba = new StoryBlock("GAME OVER", "You stand still. Unfortunately you stand too close to the demon so it notices you immediately. It attacks you GAME OVER", "Try again", "- - -", "- - -", "- - -", corridorL2baa);
    static StoryBlock corridorL2bb = new StoryBlock("Chapter 5: The Church", "You take the center corridor. You’re immediately met by a demon.", "Stand still", "Fight", "Turn back", "- - -", corridorL2ba, corridorL2bc, corridorL2bd);
    static StoryBlock corridorL2b = new StoryBlock("GAME OVER", "You use the flashlight. The demon growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", corridorL2bb);
    static StoryBlock corridorL2aend6 = new StoryBlock("GAME OVER", "You use the flashlight. The demon growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", deadend1);
    static StoryBlock corridorL2aend5 = new StoryBlock("GAME OVER", "You attempt to fight the demon but the demon proves to be too powerful. The demon growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", deadend1);
    static StoryBlock corridorL2aend4 = new StoryBlock("GAME OVER", "You use the flashlight. The demon growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", deadend1);
    static StoryBlock corridorL2aend3 = new StoryBlock("GAME OVER", "You attempt to make your way back. The demon notices you and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", deadend1);
    static StoryBlock corridorL2aend2 = new StoryBlock("GAME OVER", "You attempt to fight the demon but the demon proves to be too powerful. The demon growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", deadend1);
    static StoryBlock corridorL2aend1 = new StoryBlock("GAME OVER", "You attempt to make your way back. The demon notices you and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", deadend1);
    static StoryBlock corridorL2afinal6 = new StoryBlock("Chapter 5: The Church", "You take the center corridor. You’re immediately met by a demon.", "Use flashlight", "- - -", "- - -", "- - -", corridorL2aend6);
    static StoryBlock corridorL2afinal5 = new StoryBlock("Chapter 5: The Church", "You take the center corridor. You’re immediately met by a demon.", "Fight", "- - -", "- - -", "- - -", corridorL2aend5);
    static StoryBlock corridorL2afinal4 = new StoryBlock("Chapter 5: The Church", "You take the center corridor. You’re immediately met by a demon.", "Use flashlight", "- - -", "- - -", "- - -", corridorL2aend4);
    static StoryBlock corridorL2afinal3 = new StoryBlock("Chapter 5: The Church", "You take the center corridor. You’re immediately met by a demon.", "Turn back", "- - -", "- - -", "- - -", corridorL2aend3);
    static StoryBlock corridorL2afinal2 = new StoryBlock("Chapter 5: The Church", "You take the center corridor. You’re immediately met by a demon.", "Fight", "- - -", "- - -", "- - -", corridorL2aend2);
    static StoryBlock corridorL2afinal1 = new StoryBlock("Chapter 5: The Church", "You take the center corridor. You’re immediately met by a demon.", "Turn back", "- - -", "- - -", "- - -", corridorL2aend1);
    static StoryBlock corridorL2addb = new StoryBlock("GAME OVER", "You attempt to fight the demon but the demon proves to be too powerful. The demon growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", corridorL2afinal6);
    static StoryBlock corridorL2adda = new StoryBlock("GAME OVER", "You use the flashlight. The demon growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", corridorL2afinal5);
    static StoryBlock corridorL2accb = new StoryBlock("GAME OVER", "You attempt to make your way back. The demon notices you and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", corridorL2afinal4);
    static StoryBlock corridorL2acca = new StoryBlock("GAME OVER", "You use the flashlight. The demon growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", corridorL2afinal3);
    static StoryBlock corridorL2abbc = new StoryBlock("GAME OVER", "You attempt to make your way back. The demon notices you and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", corridorL2afinal2);
    static StoryBlock corridorL2abba = new StoryBlock("GAME OVER", "You attempt to fight the demon but the demon proves to be too powerful. The demon growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", corridorL2afinal1);
    static StoryBlock corridorL2add = new StoryBlock("Chapter 5: The Church", "You take the center corridor. You’re immediately met by a demon.", "Use flashlight", "Fight", "- - -", "- - -", corridorL2adda, corridorL2addb);
    static StoryBlock corridorL2acc = new StoryBlock("Chapter 5: The Church", "You take the center corridor. You’re immediately met by a demon.", "Use flashlight", "Turn back", "- - -", "- - -", corridorL2acca, corridorL2accb);
    static StoryBlock corridorL2abb = new StoryBlock("Chapter 5: The Church", "You take the center corridor. You’re immediately met by a demon.", "Fight", "Turn back", "- - -", "- - -", corridorL2abba, corridorL2abbc);
    static StoryBlock corridorL2ad = new StoryBlock("GAME OVER", "You attempt to make your way back. The demon notices you and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", corridorL2add);
    static StoryBlock corridorL2ac = new StoryBlock("GAME OVER", "You attempt to fight the demon but the demon proves to be too powerful. The demon growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", corridorL2acc);
    static StoryBlock corridorL2ab = new StoryBlock("GAME OVER", "You use the flashlight. The demon growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", corridorL2abb);
    static StoryBlock corridorL2aa = new StoryBlock("Chapter 5: The Church", "You take the center corridor. You’re immediately met by a demon.", "Use flashlight", "Fight", "Turn back", "- - -", corridorL2ab, corridorL2ac, corridorL2ad);
    static StoryBlock corridorL2a = new StoryBlock("GAME OVER", "You stand still. Unfortunately you stand too close to the demon so it notices you immediately. It attacks you GAME OVER", "Try again", "- - -", "- - -", "- - -", corridorL2aa);
    static StoryBlock corridorL2 = new StoryBlock("Chapter 5: The Church", "You take the center corridor. You’re immediately met by a demon.", "Stand still", "Use flashlight", "Fight", "Turn back", corridorL2a, corridorL2b, corridorL2c, corridorL2d);
    static StoryBlock corridorL1 = new StoryBlock("Chapter 5: The Church", "You wander carefully through the dark dungeon corridors. The mist is a lot thicker than before here so you know that there might be more demons lurking around. Eventually you make it to a three-way fork.", "Take the center corridor", "Take the right corridor", "- - -", "- - -", corridorL2, corridorR);
    static StoryBlock corridorL = new StoryBlock("GAME OVER", "You take the left corridor. Unbeknownst to you there is a trap door. You step on it and fall GAME OVER", "Try again", "- - -", "- - -", "- - -", corridorL1);
    static StoryBlock church10 = new StoryBlock("Chapter 5: The Church", "You wander carefully through the dark dungeon corridors. The mist is a lot thicker than before here so you know that there might be more demons lurking around. Eventually you make it to a three-way fork.", "Take the left corridor", "Take the center corridor", "Take the right corridor", "- - -", corridorL, corridorC, corridorR);
    static StoryBlock church9 = new StoryBlock("Chapter 5: The Church", "You put the jewel on the engraving. The altar starts to shake and move, revealing a hidden stairway underneath. However, the noise attracts the demon and it rushes towards you. You make a mad dash down the stairway. Luckily the stairway is too narrow for the demon to fit in so you manage to get away from it.", "Continue", "- - -", "- - -", "- - -", church10);
    static StoryBlock church8 = new StoryBlock("Chapter 5: The Church", "You notices that the candelabra has an engraving in the similar shape as the jewel", "Use jewel", "- - -", "- - -", "- - -", church9);
    //---Church7 pathing--------------------------------
    static StoryBlock church7cbb = new StoryBlock("Chapter 5: The Church", "You attempt to pull the candelabra. But turns out it’s not a secret switch", "Check candelabra", "- - -", "- - -", "- - -", church8);
    static StoryBlock church7caa = new StoryBlock("Chapter 5: The Church", "It doesn’t seem to do anything", "Check candelabra", "- - -", "- - -", "- - -", church8);
    static StoryBlock church7cb = new StoryBlock("Chapter 5: The Church", "It doesn’t seem to do anything", "Check candelabra", "Pull candelabra", "- - -", "- - -", church8, church7cbb);
    static StoryBlock church7ca = new StoryBlock("Chapter 5: The Church", "You attempt to pull the candelabra. But turns out it’s not a secret switch", "Use jewel", "Check candelabra", "- - -", "- - -", church7caa, church8);
    static StoryBlock church7c = new StoryBlock("Chapter 5: The Church", "You can’t find any matches", "Pull candelabra", "Check candelabra", "Use jewel", "- - -", church7ca, church8, church7cb);
    static StoryBlock church7bcc = new StoryBlock("Chapter 5: The Church", "You can’t find any matches", "Check candelabra", "- - -", "- - -", "- - -", church8);
    static StoryBlock church7baa = new StoryBlock("Chapter 5: The Church", "It doesn’t seem to do anything", "Check candelabra", "- - -", "- - -", "- - -", church8);
    static StoryBlock church7bc = new StoryBlock("Chapter 5: The Church", "It doesn’t seem to do anything", "Check candelabra", "Light candelabra", "- - -", "- - -", church8, church7bcc);
    static StoryBlock church7ba = new StoryBlock("Chapter 5: The Church", "You can’t find any matches", "Use jewel", "Check candelabra", "- - -", "- - -", church7baa, church8);
    static StoryBlock church7b = new StoryBlock("Chapter 5: The Church", "You attempt to pull the candelabra. But turns out it’s not a secret switch", "Light candelabra", "Check candelabra", "Use jewel", "- - -", church7ba, church8, church7bc);
    static StoryBlock church7acc = new StoryBlock("Chapter 5: The Church", "You can’t find any matches", "Check candelabra", "- - -", "- - -", "- - -", church8);
    static StoryBlock church7abb = new StoryBlock("Chapter 5: The Church", "You attempt to pull the candelabra. But turns out it’s not a secret switch", "Check candelabra", "- - -", "- - -", "- - -", church8);
    static StoryBlock church7ac = new StoryBlock("Chapter 5: The Church", "You attempt to pull the candelabra. But turns out it’s not a secret switch", "Check candelabra", "Light candelabra", "- - -", "- - -", church8, church7acc);
    static StoryBlock church7ab = new StoryBlock("Chapter 5: The Church", "You can’t find any matches", "Pull candelabra", "Check candelabra", "- - -", "- - -", church7abb, church8);
    static StoryBlock church7a = new StoryBlock("Chapter 5: The Church", "It doesn’t seem to do anything", "Light candelabra", "Check candelabra", "Pull candelabra", "- - -", church7ab, church8, church7ac);
    static StoryBlock church7 = new StoryBlock("Chapter 5: The Church", "You check the altar. You notice that one of the candelabra is strangely embedded onto the table.", "Use jewel", "Check candelabra", "Pull candelabra", "Light candelabra", church7a, church8, church7b, church7c);
    //---Church6 pathing--------------------------------
    static StoryBlock church6bbb = new StoryBlock("Chapter 5: The Church", "It doesn’t seem to do anything", "Check altar", "- - -", "- - -", "- - -", church7);
    static StoryBlock church6bb = new StoryBlock("Chapter 5: The Church", "You’re at the altar.", "Use jewel", "Check altar", "- - -", "- - -", church6bbb, church7);
    static StoryBlock church6b = new StoryBlock("GAME OVER", "You use the flashlight. The demon notices you and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", church6bb);
    static StoryBlock church6aaa = new StoryBlock("Chapter 5: The Church", "You’re at the altar.", "Check altar", "- - -", "- - -", "- - -", church7);
    static StoryBlock church6aa = new StoryBlock("GAME OVER", "You use the flashlight. The demon notices you and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", church6aaa);
    static StoryBlock church6a = new StoryBlock("Chapter 5: The Church", "It doesn’t seem to do anything", "Use flashlight", "Check altar", "- - -", "- - -", church6aa, church7);
    static StoryBlock church6 = new StoryBlock("Chapter 5: The Church", "You’re at the altar.", "Check altar", "Use jewel", "Use flashlight", "- - -", church7, church6a, church6b);
    static StoryBlock church5 = new StoryBlock("Chapter 5: The Church", "You throw the rock far away from you. The noise it makes when the rock hits the ground attracts the demon towards it. You now take your chance for the altar.", "Continue", "- - -", "- - -", "- - -", church6);
    //---Church4 pathing--------------------------------
    static StoryBlock church4final = new StoryBlock("Chapter 5: The Church", "You look around. You find some rocks.", "Throw rock", "- - -", "- - -", "- - -", church5);
    static StoryBlock church4cbbb = new StoryBlock("GAME OVER", "You throw a rock at the demon. It hits the demon but doesn’t do anything. The demon is alerted of your presence and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", church4final);
    static StoryBlock church4caaa = new StoryBlock("GAME OVER", "You attempt to run for the altar, but the demon notices you and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", church4final);
    static StoryBlock church4cbb = new StoryBlock("Chapter 5: The Church", "You look around. You find some rocks.", "Throw rock at demon", "Throw rock", "- - -", "- - -", church4cbbb, church5);
    static StoryBlock church4caa = new StoryBlock("Chapter 5: The Church", "You look around. You find some rocks.", "Throw rock", "Run", "- - -", "- - -", church5, church4caaa);
    static StoryBlock church4cb = new StoryBlock("GAME OVER", "You attempt to run for the altar, but the demon notices you and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", church4cbb);
    static StoryBlock church4ca = new StoryBlock("GAME OVER", "You throw a rock at the demon. It hits the demon but doesn’t do anything. The demon is alerted of your presence and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", church4caa);
    static StoryBlock church4cc = new StoryBlock("Chapter 5: The Church", "You look around. You find some rocks.", "Throw rock at demon", "Throw rock", "Run", "- - -", church4ca, church5, church4cb);
    static StoryBlock church4c = new StoryBlock("GAME OVER", "You use the flashlight. The demon growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", church4cc);
    static StoryBlock church4bccc = new StoryBlock("GAME OVER", "You use the flashlight. The demon growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", church4final);
    static StoryBlock church4baaa = new StoryBlock("GAME OVER", "You attempt to run for the altar, but the demon notices you and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", church4final);
    static StoryBlock church4bcc = new StoryBlock("Chapter 5: The Church", "You look around. You find some rocks.", "Use flashlight", "Throw rock", "- - -", "- - -", church4bccc, church5);
    static StoryBlock church4baa = new StoryBlock("Chapter 5: The Church", "You look around. You find some rocks.", "Throw rock", "Run", "- - -", "- - -", church5, church4baaa);
    static StoryBlock church4bc = new StoryBlock("GAME OVER", "You attempt to run for the altar, but the demon notices you and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", church4bcc);
    static StoryBlock church4ba = new StoryBlock("GAME OVER", "You use the flashlight. The demon growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", church4baa);
    static StoryBlock church4bb = new StoryBlock("Chapter 5: The Church", "You look around. You find some rocks.", "Use flashlight", "Throw rock", "Run", "- - -", church4ba, church5, church4bc);
    static StoryBlock church4b = new StoryBlock("GAME OVER", "You throw a rock at the demon. It hits the demon but doesn’t do anything. The demon is alerted of your presence and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", church4bb);
    static StoryBlock church4accc = new StoryBlock("GAME OVER", "You use the flashlight. The demon growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", church4final);
    static StoryBlock church4abbb = new StoryBlock("GAME OVER", "You throw a rock at the demon. It hits the demon but doesn’t do anything. The demon is alerted of your presence and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", church4final);
    static StoryBlock church4acc = new StoryBlock("Chapter 5: The Church", "You look around. You find some rocks.", "Use flashlight", "Throw rock", "- - -", "- - -", church4accc, church5);
    static StoryBlock church4abb = new StoryBlock("Chapter 5: The Church", "You look around. You find some rocks.", "Throw rock", "Throw rock at demon", "- - -", "- - -", church5, church4abbb);
    static StoryBlock church4ac = new StoryBlock("GAME OVER", "You throw a rock at the demon. It hits the demon but doesn’t do anything. The demon is alerted of your presence and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", church4acc);
    static StoryBlock church4ab = new StoryBlock("GAME OVER", "You use the flashlight. The demon growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", church4abb);
    static StoryBlock church4aa = new StoryBlock("Chapter 5: The Church", "You look around. You find some rocks.", "Use flashlight", "Throw rock", "Throw rock at demon", "- - -", church4ab, church5, church4ac);
    static StoryBlock church4a = new StoryBlock("GAME OVER", "You attempt to run for the altar, but the demon notices you and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", church4aa);
    static StoryBlock church4 = new StoryBlock("Chapter 5: The Church", "You look around. You find some rocks.", "Run", "Throw rock at demon", "Use flashlight", "Throw rock", church4a, church4b, church4c, church5);
    //---Church3 pathing--------------------------------
    static StoryBlock church3cfinal = new StoryBlock("Chapter 5: The Church", "Inside the church there is an altar, but there is another one of the demons creeping around.", "Stand still", "- - -", "- - -", "- - -", church4);
    static StoryBlock church3cbbb = new StoryBlock("Chapter 5: The Church", "It doesn’t seem to do anything", "Stand still", "- - -", "- - -", "- - -", church4);
    static StoryBlock church3ccc = new StoryBlock("GAME OVER", "You attempt to fight the demon but the demon proves to be too powerful. The demon growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", church3cfinal);
    static StoryBlock church3cbb = new StoryBlock("Chapter 5: The Church", "Inside the church there is an altar, but there is another one of the demons creeping around.", "Use jewel", "Stand still", "- - -", "- - -", church3cbbb, church4);
    static StoryBlock church3cc = new StoryBlock("Chapter 5: The Church", "It doesn’t seem to do anything", "Fight", "Stand still", "- - -", "- - -", church3ccc, church4);
    static StoryBlock church3cb = new StoryBlock("GAME OVER", "You attempt to fight the demon but the demon proves to be too powerful. The demon growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", church3cbb);
    static StoryBlock church3ca = new StoryBlock("Chapter 5: The Church", "Inside the church there is an altar, but there is another one of the demons creeping around.", "Look around", "Fight", "Use jewel", "- - -", church4, church3cb, church3cc);
    static StoryBlock church3c = new StoryBlock("GAME OVER", "You attempt to run for the altar, but the demon notices you and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", church3ca);
    static StoryBlock church3bfinalb = new StoryBlock("Chapter 5: The Church", "You stand still but the demon doesn’t seem to want to go anywhere", "Look around", "- - -", "- - -", "- - -", church4);
    static StoryBlock church3bfinala = new StoryBlock("Chapter 5: The Church", "You stand still but the demon doesn’t seem to want to go anywhere", "Look around", "- - -", "- - -", "- - -", church4);
    static StoryBlock church3bccc = new StoryBlock("GAME OVER", "You attempt to fight the demon but the demon proves to be too powerful. The demon growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", church3bfinalb);
    static StoryBlock church3baaa = new StoryBlock("GAME OVER", "You use the flashlight. The demon growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", church3bfinala);
    static StoryBlock church3bcc = new StoryBlock("Chapter 5: The Church", "You stand still but the demon doesn’t seem to want to go anywhere", "Look around", "Fight", "- - -", "- - -", church4, church3bccc);
    static StoryBlock church3baa = new StoryBlock("Chapter 5: The Church", "You stand still but the demon doesn’t seem to want to go anywhere", "Look around", "Use flashlight", "- - -", "- - -", church4, church3baaa);
    static StoryBlock church3bc = new StoryBlock("GAME OVER", "You use the flashlight. The demon growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", church3bcc);
    static StoryBlock church3ba = new StoryBlock("GAME OVER", "You attempt to fight the demon but the demon proves to be too powerful. The demon growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", church3baa);
    static StoryBlock church3b = new StoryBlock("Chapter 5: The Church", "It doesn’t seem to do anything", "Fight", "Look around", "Use flashlight", "- - -", church3ba, church4, church3bc);
    static StoryBlock church3afinal = new StoryBlock("Chapter 5: The Church", "You stand still but the demon doesn’t seem to want to go anywhere", "Look around", "- - -", "- - -", "- - -", church4);
    static StoryBlock church3aend = new StoryBlock("Chapter 5: The Church", "It doesn’t seem to do anything", "Look around", "- - -", "- - -", "- - -", church4);
    static StoryBlock church3acc = new StoryBlock("GAME OVER", "You use the flashlight. The demon growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", church3afinal);
    static StoryBlock church3abbb = new StoryBlock("Chapter 5: The Church", "You stand still but the demon doesn’t seem to want to go anywhere", "Use jewel", "Look around", "- - -", "- - -", church3aend, church4);
    static StoryBlock church3ac = new StoryBlock("Chapter 5: The Church", "It doesn’t seem to do anything", "Use flashlight", "Look around", "- - -", "- - -", church3acc, church4);
    static StoryBlock church3abb = new StoryBlock("GAME OVER", "You use the flashlight. The demon growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", church3abbb);
    static StoryBlock church3ab = new StoryBlock("Chapter 5: The Church", "You stand still but the demon doesn’t seem to want to go anywhere", "Look around", "Use flashlight", "Use jewel", "- - -", church4, church3abb, church3ac);
    static StoryBlock church3a = new StoryBlock("GAME OVER", "You attempt to fight the demon but the demon proves to be too powerful. The demon growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", church3ab);
    static StoryBlock church3 = new StoryBlock("Chapter 5: The Church", "You stand still but the demon doesn’t seem to want to go anywhere", "Fight", "Use jewel", "Use flashlight", "Look around", church3a, church3b, church3c, church4);
    //---Church2 pathing--------------------------------
    static StoryBlock church2cfinal = new StoryBlock("Chapter 5: The Church", "Inside the church there is an altar, but there is another one of the demons creeping around.", "Stand still", "- - -", "- - -", "- - -", church3);
    static StoryBlock church2cbbb = new StoryBlock("Chapter 5: The Church", "It doesn’t seem to do anything", "Stand still", "- - -", "- - -", "- - -", church3);
    static StoryBlock church2ccc = new StoryBlock("GAME OVER", "You use the flashlight. The demon growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", church2cfinal);
    static StoryBlock church2cbb = new StoryBlock("Chapter 5: The Church", "Inside the church there is an altar, but there is another one of the demons creeping around.", "Use jewel", "Stand still", "- - -", "- - -", church2cbbb, church3);
    static StoryBlock church2cc = new StoryBlock("Chapter 5: The Church", "It doesn’t seem to do anything", "Use flashlight", "Stand still", "- - -", "- - -", church2ccc, church3);
    static StoryBlock church2cb = new StoryBlock("GAME OVER", "You use the flashlight. The demon growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", church2cbb);
    static StoryBlock church2ca = new StoryBlock("Chapter 5: The Church", "Inside the church there is an altar, but there is another one of the demons creeping around.", "Stand still", "Use flashlight", "Use jewel", "- - -", church3, church2cb, church2cc);
    static StoryBlock church2c = new StoryBlock("GAME OVER", "You attempt to run for the altar, but the demon notices you and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", church2ca);
    static StoryBlock church2bfinal = new StoryBlock("Chapter 5: The Church", "Inside the church there is an altar, but there is another one of the demons creeping around.", "Stand still", "- - -", "- - -", "- - -", church3);
    static StoryBlock church2bbbb = new StoryBlock("Chapter 5: The Church", "It doesn’t seem to do anything", "Stand still", "- - -", "- - -", "- - -", church3);
    static StoryBlock church2bcc = new StoryBlock("GAME OVER", "You attempt to run for the altar, but the demon notices you and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", church2bfinal);
    static StoryBlock church2bbb = new StoryBlock("Chapter 5: The Church", "Inside the church there is an altar, but there is another one of the demons creeping around.", "Use jewel", "Stand still", "- - -", "- - -", church2bbbb, church3);
    static StoryBlock church2bc = new StoryBlock("Chapter 5: The Church", "It doesn’t seem to do anything", "Run", "Stand still", "- - -", "- - -", church2bcc, church3);
    static StoryBlock church2bb = new StoryBlock("GAME OVER", "You attempt to run for the altar, but the demon notices you and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", church2bbb);
    static StoryBlock church2ba = new StoryBlock("Chapter 5: The Church", "Inside the church there is an altar, but there is another one of the demons creeping around.", "Stand still", "Run", "Use jewel", "- - -", church3, church2bb, church2bc);
    static StoryBlock church2b = new StoryBlock("GAME OVER", "You use the flashlight. The demon growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", church2ba);
    static StoryBlock church2afinalb = new StoryBlock("Chapter 5: The Church", "Inside the church there is an altar, but there is another one of the demons creeping around.", "Stand still", "- - -", "- - -", "- - -", church3);
    static StoryBlock church2afinala = new StoryBlock("Chapter 5: The Church", "Inside the church there is an altar, but there is another one of the demons creeping around.", "Stand still", "- - -", "- - -", "- - -", church3);
    static StoryBlock church2accc = new StoryBlock("GAME OVER", "You attempt to run for the altar, but the demon notices you and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", church2afinalb);
    static StoryBlock church2abbb = new StoryBlock("GAME OVER", "You use the flashlight. The demon growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", church2afinala);
    static StoryBlock church2acc = new StoryBlock("Chapter 5: The Church", "Inside the church there is an altar, but there is another one of the demons creeping around.", "Stand still", "Run", "- - -", "- - -", church3, church2accc);
    static StoryBlock church2abb = new StoryBlock("Chapter 5: The Church", "Inside the church there is an altar, but there is another one of the demons creeping around.", "Stand still", "Use flashlight", "- - -", "- - -", church3, church2abbb);
    static StoryBlock church2ac = new StoryBlock("GAME OVER", "You use the flashlight. The demon growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", church2acc);
    static StoryBlock church2ab = new StoryBlock("GAME OVER", "You attempt to run for the altar, but the demon notices you and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", church2abb);
    static StoryBlock church2a = new StoryBlock("Chapter 5: The Church", "It doesn’t seem to do anything", "Run", "Stand still", "Use flashlight", "- - -", church2ab, church3, church2ac);
    static StoryBlock church2 = new StoryBlock("Chapter 5: The Church", "Inside the church there is an altar, but there is another one of the demons creeping around.", "Use jewel", "Use flashlight", "Stand still", "Run", church2a, church2b, church3, church2c);
    static StoryBlock church1 = new StoryBlock("Chapter 5: The Church", "After making your way through the mist-filled town you finally reach the Church. No matter how many times you visited the Church during your childhood it never crossed you that there was a secret dungeon in it.", "Continue", "- - -", "- - -", "- - -", church2);



    //---OFFICE--------------------------------
    static StoryBlock office17 = new StoryBlock("Chapter 4: The Town Hall", "“So that’s where we have to head next then…”", "Go to church", "- - -", "- - -", "- - -", church1);
    static StoryBlock office16 = new StoryBlock("Chapter 4: The Town Hall", "Apparently they caught wind that the police were after the mayor so they had to rush with the ritual. They say that they should rendezvous at the church’s dungeon.", "Continue", "- - -", "- - -", "- - -", office17);
    static StoryBlock office15 = new StoryBlock("Chapter 4: The Town Hall", "It was also discussed that areas that were “fogless spots” would be unaffected by the sacrifice. It wasn’t very foggy around your house, so that would explain why you weren’t sacrificed.", "Continue", "- - -", "- - -", "- - -", office16);
    static StoryBlock office14 = new StoryBlock("Chapter 4: The Town Hall", "You check through messages again to find out more. Apparently the mist is supposed to act as a conduit to bring the demons to this realm through the sacrifice. This morning was forecasted to have a thick fog so it must have been a perfect opportunity.", "Continue", "- - -", "- - -", "- - -", office15);
    static StoryBlock office13 = new StoryBlock("Chapter 4: The Town Hall", "“…But how did I not get sacrificed?”", "Continue", "- - -", "- - -", "- - -", office14);
    static StoryBlock office12 = new StoryBlock("Chapter 4: The Town Hall", "…the entire town.", "Continue", "- - -", "- - -", "- - -", office13);
    static StoryBlock office11 = new StoryBlock("Chapter 4: The Town Hall", "You learn from the messages that the mayor and this supposed cult were planning on summoning demons to this realm, but that would require a large sacrifice. That sacrifice being…", "Continue", "- - -", "- - -", "- - -", office12);
    static StoryBlock office10 = new StoryBlock("Chapter 4: The Town Hall", "In the folder you find an archive of text messages shared between the mayor and some unknown people. You also find a picture of a strange jewel similar to the one you picked up.", "Continue", "- - -", "- - -", "- - -", office11);
    static StoryBlock office9 = new StoryBlock("Chapter 4: The Town Hall", "You check the computer for any clues. You skim through folder after folder, file after file until eventually come across a folder labeled “Children of the Fog”.", "Check folder", "- - -", "- - -", "- - -", office10);
    static StoryBlock office8 = new StoryBlock("Chapter 4: The Town Hall", "…Not password protected. Phew!", "Check computer", "- - -", "- - -", "- - -", office9);
    static StoryBlock office7 = new StoryBlock("Chapter 4: The Town Hall", "You check the computer. It’s….", "Continue", "- - -", "- - -", "- - -", office8);
    static StoryBlock office6 = new StoryBlock("Chapter 4: The Town Hall", "You’re in the mayor’s office. It’s very well furnished with a black leather couch nearby. Beside it is the mayor’s computer desk.", "Check computer", "- - -", "- - -", "- - -", office7);
    static StoryBlock office5 = new StoryBlock("Chapter 4: The Town Hall", "You check the drawers. You find the key attached to a Moomin keychain. You take the key.", "Enter Mayor's office", "- - -", "- - -", "- - -", office6);
    static StoryBlock office4bfinal = new StoryBlock("Chapter 4: The Town Hall", "You check the desk. It’s very tidy, but you can’t find the key.", "Check drawers", "- - -", "- - -", "- - -", office5);
    static StoryBlock office4afinal = new StoryBlock("Chapter 4: The Town Hall", "You check the computer. Solitaire is still running. How typical!", "Check drawers", "- - -", "- - -", "- - -", office5);
    static StoryBlock office4b = new StoryBlock("Chapter 4: The Town Hall", "You check the computer. Solitaire is still running. How typical!", "Check the desk", "Check drawers", "- - -", "- - -", office4bfinal, office5);
    static StoryBlock office4a = new StoryBlock("Chapter 4: The Town Hall", "You check the desk. It’s very tidy, but you can’t find the key.", "Check drawers", "Check computer", "- - -", "- - -", office5, office4afinal);
    static StoryBlock office4 = new StoryBlock("Chapter 4: The Town Hall", "You decide to look around for a key. You check the secretary’s computer desk.", "Check the desk", "Check Computer", "Check drawers", "- - -", office4a, office4b, office5);
    //---office3 pathing--------------------------------
    static StoryBlock office3cfinalb = new StoryBlock("Chapter 4: The Town Hall", "You try to bust open the door, but you’re not strong enough to do that", "Look for key", "- - -", "- - -", "- - -", office4);
    static StoryBlock office3cfinala = new StoryBlock("Chapter 4: The Town Hall", "It doesn’t look like a key", "Look for key", "- - -", "- - -", "- - -", office4);
    static StoryBlock office3cc = new StoryBlock("Chapter 4: The Town Hall", "It doesn’t look like a key", "Bust the door open", "Look for key", "- - -", "- - -", office3cfinalb, office4);
    static StoryBlock office3cb = new StoryBlock("Chapter 4: The Town Hall", "You try to bust open the door, but you’re not strong enough to do that", "Use jewel", "Look for key", "- - -", "- - -", office3cfinala, office4);
    static StoryBlock office3c = new StoryBlock("Chapter 4: The Town Hall", "“If only I decided to keep my hair up today…”", "Look for key", "Bust the door open", "Use jewel", "- - -", office4, office3cb, office3cc);
    static StoryBlock office3bfinalb = new StoryBlock("Chapter 4: The Town Hall", "“If only I decided to keep my hair up today…”", "Look for key", "- - -", "- - -", "- - -", office4);
    static StoryBlock office3bfinala = new StoryBlock("Chapter 4: The Town Hall", "It doesn’t look like a key", "Look for key", "- - -", "- - -", "- - -", office4);
    static StoryBlock office3bc = new StoryBlock("Chapter 4: The Town Hall", "It doesn’t look like a key", "Use a bobby pin", "Look for key", "- - -", "- - -", office3bfinalb, office4);
    static StoryBlock office3bb = new StoryBlock("Chapter 4: The Town Hall", "“If only I decided to keep my hair up today…”", "Use jewel", "Look for key", "- - -", "- - -", office3bfinala, office4);
    static StoryBlock office3b = new StoryBlock("Chapter 4: The Town Hall", "You try to bust open the door, but you’re not strong enough to do that", "Look for key", "Use a bobby pin", "Use jewel", "- - -", office4, office3bb, office3bc);
    static StoryBlock office3afinalb = new StoryBlock("Chapter 4: The Town Hall", "“If only I decided to keep my hair up today…”", "Look for key", "- - -", "- - -", "- - -", office4);
    static StoryBlock office3afinala = new StoryBlock("Chapter 4: The Town Hall", "You try to bust open the door, but you’re not strong enough to do that", "Look for key", "- - -", "- - -", "- - -", office4);
    static StoryBlock office3ac = new StoryBlock("Chapter 4: The Town Hall", "You try to bust open the door, but you’re not strong enough to do that", "Use a bobby pin", "Look for key", "- - -", "- - -", office3afinalb, office4);
    static StoryBlock office3ab = new StoryBlock("Chapter 4: The Town Hall", "“If only I decided to keep my hair up today…”", "Bust the door open", "Look for key", "- - -", "- - -", office3afinala, office4);
    static StoryBlock office3a = new StoryBlock("Chapter 4: The Town Hall", "It doesn’t look like a key", "Look for key", "Use a bobby pin", "Bust the door open", "- - -", office4, office3ab, office3ac);
    static StoryBlock office3 = new StoryBlock("Chapter 4: The Town Hall", "The door is locked.", "Use jewel", "Bust the door open", "Look for key", "Use a bobby pin", office3a, office3b, office4, office3c);
    static StoryBlock office2 = new StoryBlock("Chapter 4: The Town Hall", "After carefully walking through the office area over the sea of computers either turned off or barely running you reach the mayor’s secretary office, with the entrance to the mayor’s office ahead of you", "Enter Mayor's office", "- - -", "- - -", "- - -", office3);
    static StoryBlock office1 = new StoryBlock("Chapter 4: The Town Hall", "After carefully traveling through the town avoiding more of those monsters, you make it to the town hall. Finding the mayor’s office isn’t too hard since it’s on the top floor. Strangely enough there doesn’t seem to be any monsters lurking around. You feel safe.", "Continue", "- - -", "- - -", "- - -", office2);



    //---STORE--------------------------------
    static StoryBlock store11 = new StoryBlock("Chapter 3: The Store", "You turn on the switch. A light from one of the aisle flickers on. The monster is attracted to it and moves over to the aisle. You take your chance and leave the store", "Go to Town Hall", "- - -", "- - -", "- - -", office1);
    //---store10 pathing----------------------------------------
    static StoryBlock store10 = new StoryBlock("Chapter 3: The Store", "You look around. You see a switch connecting to one of the lights", "Use switch", "- - -", "- - -", "- - -", store11);
    static StoryBlock store10c = new StoryBlock("Chapter 3: The Store", "You stand still, but it doesn’t seem that the monster is going anywhere.", "Look around", "- - -", "- - -", "- - -", store10);
    static StoryBlock store10bfinal = new StoryBlock("Chapter 3: The Store", "You take the double A batteries. They fit perfectly and your flashlight shines brightly. You make your way to the exit but find out there’s a monster blocking your way out.", "Stand still", "Look around", "- - -", "- - -", store10c, store10);
    static StoryBlock store10bbb = new StoryBlock("GAME OVER", "You use the flashlight. The monster growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", store10bfinal);
    static StoryBlock store10bb = new StoryBlock("Chapter 3: The Store", "You take the double A batteries. They fit perfectly and your flashlight shines brightly. You make your way to the exit but find out there’s a monster blocking your way out.", "Look around", "Use flashlight", "Stand still", "- - -", store10, store10bbb, store10c);
    static StoryBlock store10b = new StoryBlock("GAME OVER", "You attempt to fight the monster but the monster proves to be too powerful. The monster growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", store10bb);
    static StoryBlock store10afinal = new StoryBlock("Chapter 3: The Store", "You take the double A batteries. They fit perfectly and your flashlight shines brightly. You make your way to the exit but find out there’s a monster blocking your way out.", "Look around", "Stand still", "- - -", "- - -", store10, store10c);
    static StoryBlock store10aaa = new StoryBlock("GAME OVER", "You attempt to fight the monster but the monster proves to be too powerful. The monster growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", store10afinal);
    static StoryBlock store10aa = new StoryBlock("Chapter 3: The Store", "You take the double A batteries. They fit perfectly and your flashlight shines brightly. You make your way to the exit but find out there’s a monster blocking your way out.", "Stand still", "Look around", "Fight", "- - -", store10c, store10, store10aaa);
    static StoryBlock store10a = new StoryBlock("GAME OVER", "You use the flashlight. The monster growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", store10aa);
    static StoryBlock store9 = new StoryBlock("Chapter 3: The Store", "You take the double A batteries. They fit perfectly and your flashlight shines brightly. You make your way to the exit but find out there’s a monster blocking your way out.", "Use flashlight", "Look around", "Stand still", "Fight", store10a, store10, store10c, store10b);
    static StoryBlock c1 = new StoryBlock("Chapter 3: The Store", "You take triple A batteries. Unfortunately they are the wrong size", "Take Double A", "- - -", "- - -", "- - -", store9);
    static StoryBlock c = new StoryBlock("Chapter 3: The Store", "You take the C battery but it’s too big for the flashlight", "Take Triple A", "Take Double A", "- - -", "- - -", c1, store9);
    static StoryBlock triplea1 = new StoryBlock("Chapter 3: The Store", "You take the C battery but it’s too big for the flashlight", "Take Double A", "- - -", "- - -", "- - -", store9);
    static StoryBlock triplea = new StoryBlock("Chapter 3: The Store", "You take triple A batteries. Unfortunately they are the wrong size", "Take C", "Take Double A", "- - -", "- - -", triplea1, store9);
    static StoryBlock store8 = new StoryBlock("Chapter 3: The Store", "There are three different sizes; Double A, triple A and C.", "Take triple A", "Take Double A", "Take C", "- - -", triplea, store9, c);
    static StoryBlock store7 = new StoryBlock("Chapter 3: The Store", "You check the aisle, aside for some light bulbs and extenders, you find some batteries", "Check size", "- - -", "- - -", "- - -", store8);
    static StoryBlock store6 = new StoryBlock("Chapter 3: The Store", "You’re in the electronic aisle", "Check aisle", "- - -", "- - -", "- - -", store7);
    //---magazine scenario----------------------------------------
    static StoryBlock magazine6 = new StoryBlock("Chapter 3: The Store", "You’re in the store. There are three aisles in front of you; One for electronics, one for cosmetics, and one for magazines.", "Go to electronic aisle", "- - -", "- - -", "- - -", store6);
    static StoryBlock magazine5cfinalb = new StoryBlock("Chapter 3: The Store", "“For greasy hair? They need to be specific for this. This sounds like it’s more beneficial for greasy hair rather than the other.”", "Leave aisle", "- - -", "- - -", "- - -", magazine6);
    static StoryBlock magazine5cfinala = new StoryBlock("Chapter 3: The Store", "“I really don’t like how bright the red is, but the orange one though…”", "Leave aisle", "- - -", "- - -", "- - -", magazine6);
    static StoryBlock magazine5ccc = new StoryBlock("Chapter 3: The Store", "“I really don’t like how bright the red is, but the orange one though…”", "Schampoo", "Leave aisle", "- - -", "- - -", magazine5cfinalb, magazine6);
    static StoryBlock magazine5cc = new StoryBlock("Chapter 3: The Store", "“For greasy hair? They need to be specific for this. This sounds like it’s more beneficial for greasy hair rather than the other.”", "Leave aisle", "Lipstick", "- - -", "- - -", magazine6, magazine5cfinala);
    static StoryBlock magazine5c = new StoryBlock("Chapter 3: The Store", "“My parents loved to pester me with the face cream since I used to have terrible acne.”", "Schampoo", "Leave aisle", "Lipstick", "- - -", magazine5cc, magazine6, magazine5ccc);
    static StoryBlock magazine5bfinalb = new StoryBlock("Chapter 3: The Store", "“For greasy hair? They need to be specific for this. This sounds like it’s more beneficial for greasy hair rather than the other.”", "Leave aisle", "- - -", "- - -", "- - -", magazine6);
    static StoryBlock magazine5bfinala = new StoryBlock("Chapter 3: The Store", "“My parents loved to pester me with the face cream since I used to have terrible acne.”", "Leave aisle", "- - -", "- - -", "- - -", magazine6);
    static StoryBlock magazine5bbb = new StoryBlock("Chapter 3: The Store", "“My parents loved to pester me with the face cream since I used to have terrible acne.”", "Leave aisle", "Schampoo", "- - -", "- - -", magazine6, magazine5bfinalb);
    static StoryBlock magazine5bb = new StoryBlock("Chapter 3: The Store", "“For greasy hair? They need to be specific for this. This sounds like it’s more beneficial for greasy hair rather than the other.”", "Face cream", "Leave aisle", "- - -", "- - -", magazine5bfinala, magazine6);
    static StoryBlock magazine5b = new StoryBlock("Chapter 3: The Store", "“I really don’t like how bright the red is, but the orange one though…”", "Leave aisle", "Schampoo", "Face cream", "- - -", magazine6, magazine5bb, magazine5bbb);
    static StoryBlock magazine5afinalb = new StoryBlock("Chapter 3: The Store", "“My parents loved to pester me with the face cream since I used to have terrible acne.”", "Leave aisle", "- - -", "- - -", "- - -", magazine6);
    static StoryBlock magazine5afinala = new StoryBlock("Chapter 3: The Store", "“I really don’t like how bright the red is, but the orange one though…”", "Leave aisle", "- - -", "- - -", "- - -", magazine6);
    static StoryBlock magazine5aaa = new StoryBlock("Chapter 3: The Store", "“I really don’t like how bright the red is, but the orange one though…”", "Face cream", "Leave aisle", "- - -", "- - -", magazine5afinalb, magazine6);
    static StoryBlock magazine5aa = new StoryBlock("Chapter 3: The Store", "“My parents loved to pester me with the face cream since I used to have terrible acne.”", "Lipstick", "Leave aisle", "- - -", "- - -", magazine5afinala, magazine6);
    static StoryBlock magazine5a = new StoryBlock("Chapter 3: The Store", "“For greasy hair? They need to be specific for this. This sounds like it’s more beneficial for greasy hair rather than the other.”", "Face cream", "lipstick", "Leave aisle", "- - -", magazine5aa, magazine5aaa, magazine6);
    static StoryBlock magazine5 = new StoryBlock("Chapter 3: The Store", "There are alot of cosmetics available like shampoos, lipsticks, face cream, and more.", "Schampoo", "Lipstick", "Face cream", "Leave aisle", magazine5a, magazine5b, magazine5c, magazine6);
    static StoryBlock magazine4 = new StoryBlock("Chapter 3: The Store", "You’re in the cosmetic aisle", "Check aisle", "- - -", "- - -", "- - -", magazine5);
    static StoryBlock magazine3 = new StoryBlock("Chapter 3: The Store", "You’re in the store. There are three aisles in front of you; One for electronics, one for cosmetics, and one for magazines.", "Go to electronic aisle", "Go to cosmetic aisle", "- - -", "- - -", store6, magazine4);
    static StoryBlock magazine2bb = new StoryBlock("Chapter 3: The Store", "“I used to read these magazines alot when I was little. I always dreamed of being a fashion model.”", "Leave aisle", "- - -", "- - -", "- - -", magazine3);
    static StoryBlock magazine2aa = new StoryBlock("Chapter 3: The Store", "“Halloumi pasta? This looks good! Might make it one day.”", "Leave aisle", "- - -", "- - -", "- - -", magazine3);
    static StoryBlock magazine2b = new StoryBlock("Chapter 3: The Store", "“Halloumi pasta? This looks good! Might make it one day.”", "Leave aisle", "Fashion", "- - -", "- - -", magazine3, magazine2bb);
    static StoryBlock magazine2a = new StoryBlock("Chapter 3: The Store", "“I used to read these magazines alot when I was little. I always dreamed of being a fashion model.”", "Food", "Leave aisle", "- - -", "- - -", magazine2aa, magazine3);
    static StoryBlock magazine2 = new StoryBlock("Chapter 3: The Store", "There are alot of magazines, including fashion and food magazines.", "Fashion", "Food", "Leave aisle", "- - -", magazine2a, magazine2b, magazine3);
    static StoryBlock magazine1 = new StoryBlock("Chapter 3: The Store", "You’re in the magazine aisle", "Check aisle", "- - -", "- - -", "- - -", magazine2);
    //---cosmetic scenario----------------------------------------
    static StoryBlock cosmetic6 = new StoryBlock("Chapter 3: The Store", "You’re in the store. There are three aisles in front of you; One for electronics, one for cosmetics, and one for magazines.", "Go to electronic aisle", "- - -", "- - -", "- - -", store6);
    static StoryBlock cosmetic5bb = new StoryBlock("Chapter 3: The Store", "“I used to read these magazines alot when I was little. I always dreamed of being a fashion model.”", "Leave aisle", "- - -", "- - -", "- - -", cosmetic6);
    static StoryBlock cosmetic5aa = new StoryBlock("Chapter 3: The Store", "“Halloumi pasta? This looks good! Might make it one day.”", "Leave aisle", "- - -", "- - -", "- - -", cosmetic6);
    static StoryBlock cosmetic5b = new StoryBlock("Chapter 3: The Store", "“Halloumi pasta? This looks good! Might make it one day.”", "Leave aisle", "Fashion", "- - -", "- - -", cosmetic6, cosmetic5bb);
    static StoryBlock cosmetic5a = new StoryBlock("Chapter 3: The Store", "“I used to read these magazines alot when I was little. I always dreamed of being a fashion model.”", "Food", "Leave aisle", "- - -", "- - -", cosmetic5aa, cosmetic6);
    static StoryBlock cosmetic5 = new StoryBlock("Chapter 3: The Store", "There are alot of magazines, including fashion and food magazines.", "Fashion", "Food", "Leave aisle", "- - -", cosmetic5a, cosmetic5b, cosmetic6);
    static StoryBlock cosmetic4 = new StoryBlock("Chapter 3: The Store", "You’re in the magazine aisle", "Check aisle", "- - -", "- - -", "- - -", cosmetic5);
    static StoryBlock cosmetic3 = new StoryBlock("Chapter 3: The Store", "You’re in the store. There are three aisles in front of you; One for electronics, one for cosmetics, and one for magazines.", "Go to magazine aisle", "Go to electronic aisle", "- - -", "- - -", cosmetic4, store6);
    static StoryBlock cosmetic2cfinalb = new StoryBlock("Chapter 3: The Store", "“For greasy hair? They need to be specific for this. This sounds like it’s more beneficial for greasy hair rather than the other.”", "Leave aisle", "- - -", "- - -", "- - -", cosmetic3);
    static StoryBlock cosmetic2cfinala = new StoryBlock("Chapter 3: The Store", "“I really don’t like how bright the red is, but the orange one though…”", "Leave aisle", "- - -", "- - -", "- - -", cosmetic3);
    static StoryBlock cosmetic2ccc = new StoryBlock("Chapter 3: The Store", "“I really don’t like how bright the red is, but the orange one though…”", "Schampoo", "Leave aisle", "- - -", "- - -", cosmetic2cfinalb, cosmetic3);
    static StoryBlock cosmetic2cc = new StoryBlock("Chapter 3: The Store", "“For greasy hair? They need to be specific for this. This sounds like it’s more beneficial for greasy hair rather than the other.”", "Leave aisle", "Lipstick", "- - -", "- - -", cosmetic3, cosmetic2cfinala);
    static StoryBlock cosmetic2c = new StoryBlock("Chapter 3: The Store", "“My parents loved to pester me with the face cream since I used to have terrible acne.”", "Schampoo", "Leave aisle", "Lipstick", "- - -", cosmetic2cc, cosmetic3, cosmetic2ccc);
    static StoryBlock cosmetic2bfinalb = new StoryBlock("Chapter 3: The Store", "“For greasy hair? They need to be specific for this. This sounds like it’s more beneficial for greasy hair rather than the other.”", "Leave aisle", "- - -", "- - -", "- - -", cosmetic3);
    static StoryBlock cosmatic2bfinala = new StoryBlock("Chapter 3: The Store", "“My parents loved to pester me with the face cream since I used to have terrible acne.”", "Leave aisle", "- - -", "- - -", "- - -", cosmetic3);
    static StoryBlock cosmetic2bbb = new StoryBlock("Chapter 3: The Store", "“My parents loved to pester me with the face cream since I used to have terrible acne.”", "Leave aisle", "Schampoo", "- - -", "- - -", cosmetic3, cosmetic2bfinalb);
    static StoryBlock cosmatic2bb = new StoryBlock("Chapter 3: The Store", "“For greasy hair? They need to be specific for this. This sounds like it’s more beneficial for greasy hair rather than the other.”", "Face cream", "Leave aisle", "- - -", "- - -", cosmatic2bfinala, cosmetic3);
    static StoryBlock cosmatic2b = new StoryBlock("Chapter 3: The Store", "“I really don’t like how bright the red is, but the orange one though…”", "Leave aisle", "Schampoo", "Face cream", "- - -", cosmetic3, cosmatic2bb, cosmetic2bbb);
    static StoryBlock cosmetic2afinalb = new StoryBlock("Chapter 3: The Store", "“My parents loved to pester me with the face cream since I used to have terrible acne.”", "Leave aisle", "- - -", "- - -", "- - -", cosmetic3);
    static StoryBlock cosmetic2afinala = new StoryBlock("Chapter 3: The Store", "“I really don’t like how bright the red is, but the orange one though…”", "Leave aisle", "- - -", "- - -", "- - -", cosmetic3);
    static StoryBlock cosmetic2aaa = new StoryBlock("Chapter 3: The Store", "“I really don’t like how bright the red is, but the orange one though…”", "Face cream", "Leave aisle", "- - -", "- - -", cosmetic2afinalb, cosmetic3);
    static StoryBlock cosmetic2aa = new StoryBlock("Chapter 3: The Store", "“My parents loved to pester me with the face cream since I used to have terrible acne.”", "Lipstick", "Leave aisle", "- - -", "- - -", cosmetic2afinala, cosmetic3);
    static StoryBlock cosmetic2a = new StoryBlock("Chapter 3: The Store", "“For greasy hair? They need to be specific for this. This sounds like it’s more beneficial for greasy hair rather than the other.”", "Face cream", "lipstick", "Leave aisle", "- - -", cosmetic2aa, cosmetic2aaa, cosmetic3);
    static StoryBlock cosmetic2 = new StoryBlock("Chapter 3: The Store", "There are alot of cosmetics available like shampoos, lipsticks, face cream, and more.", "Schampoo", "Lipstick", "Face cream", "Leave aisle", cosmetic2a, cosmatic2b, cosmetic2c, cosmetic3);
    static StoryBlock cosmetic1 = new StoryBlock("Chapter 3: The Store", "You’re in the cosmetic aisle", "Check aisle", "- - -", "- - -", "- - -", cosmetic2);
    //-----------------------------------
    static StoryBlock store5 = new StoryBlock("Chapter 3: The Store", "You’re in the store. There are three aisles in front of you; One for electronics, one for cosmetics, and one for magazines.", "Go to cosmetic aisle", "Go to electronic aisle", "Go to magazine aisle", "- - -", cosmetic1, store6, magazine1);
    static StoryBlock store4 = new StoryBlock("Chapter 3: The Store", "As the monster wanders away from you, you sneak into the store.", "Continue", "- - -", "- - -", "- - -", store5);
    //---Store scenario 2----------------------------------------
    static StoryBlock storescenario2b = new StoryBlock("Chapter 3: The Store", "You stand still. The monster wanders around for a bit without noticing you. It starts wandering away from you.", "Sneak to store", "- - -", "- - -", "- - -", store4);
    static StoryBlock storescenario2a = new StoryBlock("GAME OVER", "You make some noise. The monster hears you and it lunges back at you GAME OVER", "Try again", "- - -", "- - -", "- - -", storescenario2b);
    static StoryBlock storescenario2 = new StoryBlock("Chapter 3: The Store", "You stand still. The monster wanders around for a bit without noticing you. It starts wandering away from you.", "Sneak to store", "Yell", "- - -", "- - -", store4, storescenario2a);
    //---Store scenario 1----------------------------------------
    static StoryBlock storescenario1final = new StoryBlock("Chapter 3: The Store", "You turn off the flashlight. The monster can’t seem to notice you anymore. Eventually it leaves.", "Sneak to store", "- - -", "- - -", "- - -", store4);
    static StoryBlock storescenario1bfinal = new StoryBlock("Chapter 3: The Store", "The dim light attracts the monster, but it doesn’t seem to notice you", "Turn off flashlight", "- - -", "- - -", "- - -", storescenario1final);
    static StoryBlock storescenario1bbb = new StoryBlock("GAME OVER", "You attempt to run away, the monster notices you and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", storescenario1bfinal);
    static StoryBlock storescenario1bb = new StoryBlock("Chapter 3: The Store", "The dim light attracts the monster, but it doesn’t seem to notice you", "Turn off flashlight", "Run", "- - -", "- - -", storescenario1final, storescenario1bbb);
    static StoryBlock storescenario1b = new StoryBlock("GAME OVER", "You attempt to fight the monster but the monster proves to be too powerful. The monster growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", storescenario1bb);
    static StoryBlock storescenario1afinal = new StoryBlock("Chapter 3: The Store", "The dim light attracts the monster, but it doesn’t seem to notice you", "Turn off flashlight", "- - -", "- - -", "- - -", storescenario1final);
    static StoryBlock storescenario1aaa = new StoryBlock("GAME OVER", "You attempt to fight the monster but the monster proves to be too powerful. The monster growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", storescenario1afinal);
    static StoryBlock storescenario1aa = new StoryBlock("Chapter 3: The Store", "The dim light attracts the monster, but it doesn’t seem to notice you", "Fight", "Turn off flashlight", "- - -", "- - -", storescenario1aaa, storescenario1final);
    static StoryBlock storescenario1a = new StoryBlock("GAME OVER", "You attempt to run away, the monster notices you and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", storescenario1aa);
    static StoryBlock storescenario1 = new StoryBlock("Chapter 3: The Store", "The dim light attracts the monster, but it doesn’t seem to notice you", "Run", "Turn off flashlight", "Fight", "- - -", storescenario1a, storescenario1final, storescenario1b);
    //-----------------------------------
    static StoryBlock store3 = new StoryBlock("Chapter 3: The Store", "You make it to the convenience store. The parking lot is empty with maybe about 2-4 abandoned cars parked on it. However you hear some noise. You immediately freeze and look around. You see another one of those things skulking around.", "Use flashlight", "Stand still", "- - -", "- - -", storescenario1, storescenario2);
    static StoryBlock store2 = new StoryBlock("GAME OVER", "You make some noise. The monster hears you and it lunges back at you GAME OVER", "Try again", "- - -", "- - -", "- - -", store3);
    static StoryBlock store1 = new StoryBlock("Chapter 3: The Store", "You make it to the convenience store. The parking lot is empty with maybe about 2-4 abandoned cars parked on it. However you hear some noise. You immediately freeze and look around. You see another one of those things skulking around.", "Use flashlight", "Stand still", "Yell", "- - -", storescenario1, storescenario2, store2);



    //---HOUSE--------------------------------
    static StoryBlock workroom11 = new StoryBlock("Chapter 2: The House", "You search the house for spare batteries but find none. You realize you need to go to a convenience store to find batteries.", "Go to store", "- - -", "- - -", "- - -", store1);
    static StoryBlock workroom10a = new StoryBlock("Chapter 2: The House", "“I can’t do that right now”", "Search for batteries", "- - -", "- - -", "- - -", workroom11);
    static StoryBlock workroom10 = new StoryBlock("Chapter 2: The House", "You gather the clues necessary to make the next step. However, you notice the light from your flashlight is dim, which means you need to find spare batteries", "Leave", "Search for batteries", "- - -", "- - -", workroom10a, workroom11);
    static StoryBlock workroom9 = new StoryBlock("Chapter 2: The House", "“We have evidence that the mayor has ties with the so-called satanic cult. However, we can’t make the necessary arrests unless we’re able to interrogate the mayor for further arrest. We shall launch a raid tomorrow.”", "Continue", "- - -", "- - -", "- - -", workroom10);
    //---safe pathing----------------------------------------
    static StoryBlock safe2a = new StoryBlock("Chapter 2: The House", "It appears to be old, almost Victorian. It gives you a creepy feeling, but you feel like it might be important. You take the jewel.", "Read message", "- - -", "- - -", "- - -", workroom9);
    static StoryBlock safe2 = new StoryBlock("Chapter 2: The House", "You open the folder. It contains a message.", "Check jewel", "- - -", "- - -", "- - -", safe2a);
    static StoryBlock safe1a = new StoryBlock("Chapter 2: The House", "You open the folder. It contains a message.", "Read message", "- - -", "- - -", "- - -", workroom9);
    static StoryBlock safe1 = new StoryBlock("Chapter 2: The House", "It appears to be old, almost Victorian. It gives you a creepy feeling, but you feel like it might be important. You take the jewel.", "Check folder", "- - -", "- - -", "- - -", safe1a);
    static StoryBlock workroom8 = new StoryBlock("Chapter 2: The House", "You use the combination on the safe. The safe opens. In the safe you find some strange jewelry and a folder.", "Check jewel", "Check folder", "- - -", "- - -", safe1, safe2);
    static StoryBlock workroom7 = new StoryBlock("Chapter 2: The House", "The safe appears to use a 4 number combination.", "Use code", "- - -", "- - -", "- - -", workroom8);
    static StoryBlock workroom6 = new StoryBlock("Chapter 2: The House", "You open the drawer. Aside from a few papers you find a small note with a four-number code", "Check safe", "- - -", "- - -", "- - -", workroom7);
    static StoryBlock workroom5 = new StoryBlock("Chapter 2: The House", "It’s a simple work table with a computer, a calendar and stacks of paper. The work table has a drawer.", "Check drawer", "- - -", "- - -", "- - -", workroom6);
    //---workroom pathing----------------------------------------
    static StoryBlock calendar5 = new StoryBlock("Chapter 2: The House", "“I would say I’m quite a bookworm myself, but no way I would find the code there”", "Search work table", "- - -", "- - -", "- - -", workroom5);
    static StoryBlock calendar4 = new StoryBlock("Chapter 2: The House", "“It’s a mess”. You're unable to find the codes here.", "Search work table", "- - -", "- - -", "- - -", workroom5);
    static StoryBlock calendar3 = new StoryBlock("Chapter 2: The House", "“It’s a mess”. You're unable to find the codes here.", "Search bookshelf", "Search work table", "- - -", "- - -", calendar5, workroom5);
    static StoryBlock calendar2 = new StoryBlock("Chapter 2: The House", "“I would say I’m quite a bookworm myself, but no way I would find the code there”", "Search papers", "Search work table", "- - -", "- - -", calendar4, workroom5);
    static StoryBlock calendar1 = new StoryBlock("Chapter 2: The House", "The calendar is set to October. It’s marked around 31th. That’s today.", "Search work table", "Search bookshelf", "Search papers", "- - -", workroom5, calendar2, calendar3);
    static StoryBlock book5 = new StoryBlock("Chapter 2: The House", "The calendar is set to October. It’s marked around 31th. That’s today.", "Search work table", "- - -", "- - -", "- - -", workroom5);
    static StoryBlock book4 = new StoryBlock("Chapter 2: The House", "“It’s a mess”. You're unable to find the codes here.", "Search work table", "- - -", "- - -", "- - -", workroom5);
    static StoryBlock book3 = new StoryBlock("Chapter 2: The House", "“It’s a mess”. You're unable to find the codes here.", "Check calendar", "Search work table", "- - -", "- - -", book5, workroom5);
    static StoryBlock book2 = new StoryBlock("Chapter 2: The House", "The calendar is set to October. It’s marked around 31th. That’s today.", "Search papers", "Search work table", "- - -", "- - -", book4, workroom5);
    static StoryBlock book1 = new StoryBlock("Chapter 2: The House", "“I would say I’m quite a bookworm myself, but no way I would find the code there”", "Check calendar", "Search papers", "Check work table", "- - -", book2, book3, workroom5);
    static StoryBlock paper5 = new StoryBlock("Chapter 2: The House", "The calendar is set to October. It’s marked around 31th. That’s today.", "Search worktable", "- - -", "- - -", "- - -", workroom5);
    static StoryBlock paper4 = new StoryBlock("Chapter 2: The House", "“I would say I’m quite a bookworm myself, but no way I would find the code there”", "Search worktable", "- - -", "- - -", "- - -", workroom5);
    static StoryBlock paper3 = new StoryBlock("Chapter 2: The House", "“I would say I’m quite a bookworm myself, but no way I would find the code there”", "Check calendar", "Search work table", "- - -", "- - -", paper5, workroom5);
    static StoryBlock paper2 = new StoryBlock("Chapter 2: The House", "The calendar is set to October. It’s marked around 31th. That’s today.", "Search bookshelf", "Search work table", "- - -", "- - -", paper4, workroom5);
    static StoryBlock paper1 = new StoryBlock("Chapter 2: The House", "“It’s a mess”. You're unable to find the codes here.", "Search work table", "Check calendar", "Search bookshelf", "- - -", workroom5, paper2, paper3);
    static StoryBlock workroom4 = new StoryBlock("Chapter 2: The House", "It’s a small computer room. There are lots of paper scattered around, and a bookshelf full of books.", "Search papers", "Search bookshelf", "Search work table", "Check calendar", paper1, book1, workroom5, calendar1);
    static StoryBlock workroom3 = new StoryBlock("Chapter 2: The House", "“I don’t know that”", "Check room", "- - -", "- - -", "- - -", workroom4);
    static StoryBlock workroom2 = new StoryBlock("Chapter 2: The House", "The safe appears to use a 4 number combination.", "Use code", "- - -", "- - -", "- - -", workroom3);
    static StoryBlock workroom1 = new StoryBlock("Chapter 2: The House", "You go to the workroom. It’s a small computer room. There are lots of paper scattered around, and a bookshelf full of books. You also spot a safe hidden behind the bookshelf. Could that be where the folder is located?", "Check safe", "- - -", "- - -", "- - -", workroom2);
    static StoryBlock hallway5 = new StoryBlock("Chapter 2: The House", "“I should probably check the workroom”", "Go to workroom", "- - -", "- - -", "- - -", workroom1);
    static StoryBlock hallway4 = new StoryBlock("Chapter 2: The House", "“Remember to grab the folder on the workroom before leaving”", "Continue", "- - -", "- - -", "- - -", hallway5);
    static StoryBlock hallway3 = new StoryBlock("Chapter 2: The House", "You check the cabinet. You find a note.", "Read note", "- - -", "- - -", "- - -", hallway4);
    //---hallway pathing----------------------------------------
    static StoryBlock mirror5 = new StoryBlock("Chapter 2: The House", "On the photos there are two adults and two kids. They’re all smiling, you see a church in the background on one of the photos", "Check cabinet", "- - -", "- - -", "- - -", hallway3);
    static StoryBlock mirror4 = new StoryBlock("Chapter 2: The House", "“I can’t do that right now”", "Check cabinet", "- - -", "- - -", "- - -", hallway3);
    static StoryBlock mirror3 = new StoryBlock("Chapter 2: The House", "“I can’t do that right now”", "Check photos", "Check cabinet", "- - -", "- - -", mirror5, hallway3);
    static StoryBlock mirror2 = new StoryBlock("Chapter 2: The House", "On the photos there are two adults and two kids. They’re all smiling, you see a church in the background on one of the photos", "Leave", "Check cabinet", "- - -", "- - -", mirror4, hallway3);
    static StoryBlock mirror1 = new StoryBlock("Chapter 2: The House", "“Looking good”", "Check photos", "Check cabinet", "Leave", "- - -", mirror2, hallway3, mirror3);
    static StoryBlock photos5 = new StoryBlock("Chapter 2: The House", "“I can’t do that right now”", "Check cabinet", "- - -", "- - -", "- - -", hallway3);
    static StoryBlock photos4 = new StoryBlock("Chapter 2: The House", "“Looking good”", "Check cabinet", "- - -", "- - -", "- - -", hallway3);
    static StoryBlock photos3 = new StoryBlock("Chapter 2: The House", "“Looking good”", "Leave", "Check cabinet", "- - -", "- - -", photos5, hallway3);
    static StoryBlock photos2 = new StoryBlock("Chapter 2: The House", "“I can’t do that right now”", "Look at mirror", "Check cabinet", "- - -", "- - -", photos4, hallway3);
    static StoryBlock photos1 = new StoryBlock("Chapter 2: The House", "On the photos there are two adults and two kids. They’re all smiling, you see a church in the background on one of the photos", "Leave", "Check cabinet", "Look at mirror", "- - -", photos2, hallway3, photos3);
    static StoryBlock hallway2d = new StoryBlock("Chapter 2: The House", "On the photos there are two adults and two kids. They’re all smiling, you see a church in the background on one of the photos", "Check cabinet", "- - -", "- - -", "- - -", hallway3);
    static StoryBlock hallway2c = new StoryBlock("Chapter 2: The House", "“Looking good”", "Check cabinet", "- - -", "- - -", "- - -", hallway3);
    static StoryBlock hallway2b = new StoryBlock("Chapter 2: The House", "“Looking good”", "Check photos", "Check cabinet", "- - -", "- - -", hallway2d, hallway3);
    static StoryBlock hallway2a = new StoryBlock("Chapter 2: The House", "On the photos there are two adults and two kids. They’re all smiling, you see a church in the background on one of the photos", "Look at mirror", "Check cabinet", "- - -", "- - -", hallway2c, hallway3);
    static StoryBlock hallway2 = new StoryBlock("Chapter 2: The House", "“I can’t do that right now”", "Check photos", "Check cabinet", "Look at mirror", "- - -", hallway2a, hallway3, hallway2b);
    static StoryBlock hallway1 = new StoryBlock("Chapter 2: The House", "You leave the kitchen. You find yourself in the hallway. To your left you find a cabinet.To your right you find a mirror and some photos.", "Leave", "Check photos", "Check cabinet", "Look at mirror", hallway2, photos1, hallway3, mirror1);
    //---kitchen pathing----------------------------------------
    static StoryBlock kitchen4 = new StoryBlock("Chapter 2: The House", "“This kitchen reminds me of my aunt’s kitchen”", "Go to hallway", "- - -", "- - -", "- - -", hallway1);
    static StoryBlock kitchen3 = new StoryBlock("Chapter 2: The House", "“I'm not hungry.”", "Go to hallway", "- - -", "- - -", "- - -", hallway1);
    static StoryBlock kitchen2 = new StoryBlock("Chapter 2: The House", "“I'm not hungry.”", "Go to hallway", "Look around", "- - -", "- - -", hallway1, kitchen4);
    static StoryBlock kitchen1 = new StoryBlock("Chapter 2: The House", "“This kitchen reminds me of my aunt’s kitchen”", "Go to hallway", "Make food", "- - -", "- - -", hallway1, kitchen3);
    static StoryBlock house5 = new StoryBlock("Chapter 2: The House", "Using the flashlight illuminates the room. You find yourself in a kitchen. To your right you find a doorway to the hallway.", "Look around", "Go to hallway", "Make food", "- - -", kitchen1, hallway1, kitchen2);
    //---house1 pathing----------------------------------------
    static StoryBlock house4d = new StoryBlock("Chapter 2: The House", "“I wouldn’t want to go outside with that “thing” out there”", "Use flashlight", "- - -", "- - -", "- - -", house5);
    static StoryBlock house4c = new StoryBlock("Chapter 2: The House", "“It’s too dark”", "Use flashlight", "- - -", "- - -", "- - -", house5);
    static StoryBlock house4b = new StoryBlock("Chapter 2: The House", "“It’s too dark”", "Go outside", "Use flashlight", "- - -", "- - -", house4d, house5);
    static StoryBlock house4a = new StoryBlock("Chapter 2: The House", "“I wouldn’t want to go outside with that “thing” out there”", "Look around", "Use flashlight", "- - -", "- - -", house4c, house5);
    static StoryBlock house4 = new StoryBlock("Chapter 2: The House", "You attempt to call for someone, but no one came.", "Go outside", "Use flashlight", "Look around", "- - -", house4a, house5, house4b);
    static StoryBlock house3d = new StoryBlock("Chapter 2: The House", "“I wouldn’t want to go outside with that “thing” out there”", "Use flashlight", "- - -", "- - -", "- - -", house5);
    static StoryBlock house3c = new StoryBlock("Chapter 2: The House", "You attempt to call for someone, but no one came.", "Use flashlight", "- - -", "- - -", "- - -", house5);
    static StoryBlock house3b = new StoryBlock("Chapter 2: The House", "You attempt to call for someone, but no one came.", "Go outside", "Use flashlight", "- - -", "- - -", house3d, house5);
    static StoryBlock house3a = new StoryBlock("Chapter 2: The House", "“I wouldn’t want to go outside with that “thing” out there”", "Call", "Use flashlight", "- - -", "- - -", house3c, house5);
    static StoryBlock house3 = new StoryBlock("Chapter 2: The House", "“It’s too dark”", "Go outside", "Use flashlight", "Call", "- - -", house3a, house5, house3b);
    static StoryBlock house2d = new StoryBlock("Chapter 2: The House", "“It’s too dark”", "Use flashlight", "- - -", "- - -", "- - -", house5);
    static StoryBlock house2c = new StoryBlock("Chapter 2: The House", "You attempt to call for someone, but no one came.", "Use flashlight", "- - -", "- - -", "- - -", house5);
    static StoryBlock house2b = new StoryBlock("Chapter 2: The House", "You attempt to call for someone, but no one came.", "Look around", "Use flashlight", "- - -", "- - -", house2d, house5);
    static StoryBlock house2a = new StoryBlock("Chapter 2: The House", "“It’s too dark”", "Call", "Use flashlight", "- - -", "- - -", house2c, house5);
    static StoryBlock house2 = new StoryBlock("Chapter 2: The House", "“I wouldn’t want to go outside with that “thing” out there”", "Look around", "Use flashlight", "Call", "- - -", house2a, house5, house2b);
    static StoryBlock house1 = new StoryBlock("Chapter 2: The House", "You’re inside the house. It appears to be dark.", "Go outside", "Look around", "Call", "Use flashlight", house2, house3, house4, house5);



    //---CRASH--------------------------------
    static StoryBlock crash7 = new StoryBlock("Chapter 1: The Crash", "You look around. You find a house in front of you. You decide to go inside the house", "Go to house", "- - -", "- - -", "- - -", house1);
    //---crash5 pathing----------------------------------------
    static StoryBlock crash8final = new StoryBlock("Chapter 1: The Crash", "You stand still. The monster checks around but seems unable to find you. The monster leaves. With the monster gone you find yourself all alone.", "Look around", "- - -", "- - -", "- - -", crash7);
    static StoryBlock crash8ab = new StoryBlock("GAME OVER", "You use the flashlight. It attracts the monster towards you and it lunges back at you GAME OVER", "Try again", "- - -", "- - -", "- - -", crash8final);
    static StoryBlock crash8a = new StoryBlock("Chapter 1: The Crash", "You stand still. The monster checks around but seems unable to find you. The monster leaves. With the monster gone you find yourself all alone.", "Use flashlight", "Look around", "- - -", "- - -", crash8ab, crash7);
    static StoryBlock crash8 = new StoryBlock("GAME OVER", "You make some noise. The monster hears you and it lunges back at you GAME OVER", "Try again", "- - -", "- - -", "- - -", crash8a);
    static StoryBlock crash6final = new StoryBlock("Chapter 1: The Crash", "You stand still. The monster checks around but seems unable to find you. The monster leaves. With the monster gone you find yourself all alone.", "Look around", "- - -", "- - -", "- - -", crash7);
    static StoryBlock crash6ab = new StoryBlock("GAME OVER", "You make some noise. The monster hears you and it lunges back at you GAME OVER", "Try again", "- - -", "- - -", "- - -", crash6final);
    static StoryBlock crash6a = new StoryBlock("Chapter 1: The Crash", "You stand still. The monster checks around but seems unable to find you. The monster leaves. With the monster gone you find yourself all alone.", "Scream", "Look around", "- - -", "- - -", crash6ab, crash7);
    static StoryBlock crash6 = new StoryBlock("GAME OVER", "You use the flashlight. It attracts the monster towards you and it lunges back at you GAME OVER", "Try again", "- - -", "- - -", "- - -", crash6a);
    static StoryBlock crash5 = new StoryBlock("Chapter 1: The Crash", "You stand still. The monster checks around but seems unable to find you. The monster leaves. With the monster gone you find yourself all alone.", "Use flashlight", "Look around", "Scream", "- - -", crash6, crash7, crash8 );
    //---crash1 pathing----------------------------------------
    static StoryBlock crash4final = new StoryBlock("Chapter 1: The Crash", "You recover from the crash. You feel a bit dazed, but you eventually come to and crawl out of the car. While doing so you manage to grab something from the glove box: A flashlight, just in case your car breaks down while driving during the night. When you get up you face the monster in front of you.", "Stand still", "- - -", "- - -", "- - -", crash5);
    static StoryBlock crash4accc = new StoryBlock("GAME OVER", "You use the flashlight. The monster growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", crash4final);
    static StoryBlock crash4abbb = new StoryBlock("GAME OVER", "You attempt to run away, but the monster catches up with you and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", crash4final);
    static StoryBlock crash4acc = new StoryBlock("Chapter 1: The Crash", "You recover from the crash. You feel a bit dazed, but you eventually come to and crawl out of the car. While doing so you manage to grab something from the glove box: A flashlight, just in case your car breaks down while driving during the night. When you get up you face the monster in front of you.", "Use flashlight", "Stand still", "- - -", "- - -", crash4accc, crash5);
    static StoryBlock crash4abb = new StoryBlock("Chapter 1: The Crash", "You recover from the crash. You feel a bit dazed, but you eventually come to and crawl out of the car. While doing so you manage to grab something from the glove box: A flashlight, just in case your car breaks down while driving during the night. When you get up you face the monster in front of you.", "Run", "Stand still", "- - -", "- - -", crash4abbb, crash5);
    static StoryBlock crash4ac = new StoryBlock("GAME OVER", "You attempt to run away, but the monster catches up with you and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", crash4acc);
    static StoryBlock crash4ab = new StoryBlock("GAME OVER", "You use the flashlight. The monster growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", crash4abb);
    static StoryBlock crash4a = new StoryBlock("Chapter 1: The Crash", "You recover from the crash. You feel a bit dazed, but you eventually come to and crawl out of the car. While doing so you manage to grab something from the glove box: A flashlight, just in case your car breaks down while driving during the night. When you get up you face the monster in front of you.", "Stand still", "Use flashlight", "Run", "- - -", crash5, crash4ab, crash4ac);
    static StoryBlock crash4 = new StoryBlock("GAME OVER", "You attempt to fight the monster but the monster proves to be too powerful. The monster growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", crash4a);
    static StoryBlock crash3final = new StoryBlock("Chapter 1: The Crash", "You recover from the crash. You feel a bit dazed, but you eventually come to and crawl out of the car. While doing so you manage to grab something from the glove box: A flashlight, just in case your car breaks down while driving during the night. When you get up you face the monster in front of you.", "Stand still", "- - -", "- - -", "- - -", crash5);
    static StoryBlock crash3accc = new StoryBlock("GAME OVER", "You use the flashlight. The monster growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", crash3final);
    static StoryBlock crash3abbb = new StoryBlock("GAME OVER", "You attempt to fight the monster but the monster proves to be too powerful. The monster growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", crash3final);
    static StoryBlock crash3acc = new StoryBlock("Chapter 1: The Crash", "You recover from the crash. You feel a bit dazed, but you eventually come to and crawl out of the car. While doing so you manage to grab something from the glove box: A flashlight, just in case your car breaks down while driving during the night. When you get up you face the monster in front of you.", "Use flashlight", "Stand still", "- - -", "- - -", crash3accc, crash5);
    static StoryBlock crash3abb = new StoryBlock("Chapter 1: The Crash", "You recover from the crash. You feel a bit dazed, but you eventually come to and crawl out of the car. While doing so you manage to grab something from the glove box: A flashlight, just in case your car breaks down while driving during the night. When you get up you face the monster in front of you.", "Fight", "Stand still", "- - -", "- - -", crash3abbb, crash5);
    static StoryBlock crash3ac = new StoryBlock("GAME OVER", "You attempt to fight the monster but the monster proves to be too powerful. The monster growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", crash3acc);
    static StoryBlock crash3ab = new StoryBlock("GAME OVER", "You use the flashlight. The monster growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", crash3abb);
    static StoryBlock crash3a = new StoryBlock("Chapter 1: The Crash", "You recover from the crash. You feel a bit dazed, but you eventually come to and crawl out of the car. While doing so you manage to grab something from the glove box: A flashlight, just in case your car breaks down while driving during the night. When you get up you face the monster in front of you.", "Stand still", "Use flashlight", "Fight", "- - -", crash5, crash3ab, crash3ac);
    static StoryBlock crash3 = new StoryBlock("GAME OVER", "You attempt to run away, but the monster catches up with you and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", crash3a);
    static StoryBlock crash2final = new StoryBlock("Chapter 1: The Crash", "You recover from the crash. You feel a bit dazed, but you eventually come to and crawl out of the car. While doing so you manage to grab something from the glove box: A flashlight, just in case your car breaks down while driving during the night. When you get up you face the monster in front of you.", "Stand still", "- - -", "- - -", "- - -", crash5);
    static StoryBlock crash2accc = new StoryBlock("GAME OVER", "You attempt to run away, but the monster catches up with you and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", crash2final);
    static StoryBlock crash2abbb = new StoryBlock("GAME OVER", "You attempt to fight the monster but the monster proves to be too powerful. The monster growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", crash2final);
    static StoryBlock crash2acc = new StoryBlock("Chapter 1: The Crash", "You recover from the crash. You feel a bit dazed, but you eventually come to and crawl out of the car. While doing so you manage to grab something from the glove box: A flashlight, just in case your car breaks down while driving during the night. When you get up you face the monster in front of you.", "Run", "Stand still", "- - -", "- - -", crash2accc, crash5);
    static StoryBlock crash2abb = new StoryBlock("Chapter 1: The Crash", "You recover from the crash. You feel a bit dazed, but you eventually come to and crawl out of the car. While doing so you manage to grab something from the glove box: A flashlight, just in case your car breaks down while driving during the night. When you get up you face the monster in front of you.", "Fight", "Stand still", "- - -", "- - -", crash2abbb, crash5);
    static StoryBlock crash2ac = new StoryBlock("GAME OVER", "You attempt to fight the monster but the monster proves to be too powerful. The monster growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", crash2acc);
    static StoryBlock crash2ab = new StoryBlock("GAME OVER", "You attempt to run away, but the monster catches up with you and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", crash2abb);
    static StoryBlock crash2a = new StoryBlock("Chapter 1: The Crash", "You recover from the crash. You feel a bit dazed, but you eventually come to and crawl out of the car. While doing so you manage to grab something from the glove box: A flashlight, just in case your car breaks down while driving during the night. When you get up you face the monster in front of you.", "Stand still", "Run", "Fight", "- - -", crash5, crash2ab, crash2ac);
    static StoryBlock crash2 = new StoryBlock("GAME OVER", "You use the flashlight. The monster growls and lunges towards you GAME OVER", "Try again", "- - -", "- - -", "- - -", crash2a);
    static StoryBlock crash1 = new StoryBlock("Chapter 1: The Crash", "You recover from the crash. You feel a bit dazed, but you eventually come to and crawl out of the car. While doing so you manage to grab something from the glove box: A flashlight, just in case your car breaks down while driving during the night. When you get up you face the monster in front of you.", "Use flashlight", "Run", "Fight", "Stand still", crash2, crash3, crash4, crash5);



    //---INTRO--------------------------------
    static StoryBlock intro3 = new StoryBlock("", "But as you drive suddenly a strange figure appears before you. It’s strange, almost terrifying. The thing notices you, but doesn’t move. You honk at it, but it suddenly starts rushing towards you. You make a sharp turn to avoid it but you swerve off and crash your car.", "Start adventuring!", "- - -", "- - -", "- - -", crash1);
    static StoryBlock intro2 = new StoryBlock("", "As you drive you notice that the roads are unusually empty and each house has no light coming through the window. You’re a bit confused, wondering if you got up earlier than everyone else. But it’s something you shouldn’t bother with, you just need to get to work.", "Continue", "- - -", "- - -", "- - -", intro3);
    static StoryBlock intro1 = new StoryBlock("", "You wake up one early morning. You eat breakfast, get ready for the day and step out from your apartment. It’s a thick fog, but nothing unusual. Early mornings usually have thick fogs, so they will dissipate later today. You get into the car and drive carefully away.", "Continue", "- - -", "- - -", "- - -", intro2);



    // Start is called before the first frame update
    void Start()
    {
        DisplayBlock(intro1);
    }

    void DisplayBlock(StoryBlock block)
    {
        title.text = block.title;
        mainText.text = block.story;

        option1.GetComponentInChildren<TextMeshProUGUI>().text = block.option1Text;
        option2.GetComponentInChildren<TextMeshProUGUI>().text = block.option2Text;
        option3.GetComponentInChildren<TextMeshProUGUI>().text = block.option3Text;
        option4.GetComponentInChildren<TextMeshProUGUI>().text = block.option4Text;

        currentBlock = block;
    }

    public void Button1Clicked()
    {
        DisplayBlock(currentBlock.option1Block);
    }

    public void Button2Clicked()
    {
        DisplayBlock(currentBlock.option2Block);
    }

    public void Button3Clicked()
    {
        DisplayBlock(currentBlock.option3Block);
    }

    public void Button4Clicked()
    {
        DisplayBlock(currentBlock.option4Block);
    }

}

