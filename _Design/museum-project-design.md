# Project #1: Personal Museum (design decisions so far)

## Story
Player is late for book club; his sister hid his book (Steppenwolf) in the study and left a riddle. Stress bar (top right) drops as he interacts with meaningful objects.

## Rooms
- Hallway: small, narrow. Bag near the front door, study door at the other end.
- Study: single square room. Desk + lamp in the middle, bookshelf on one wall, whiteboard + armchair in a corner, radio on a side table, Led Zeppelin poster on a wall.
- Steppenwolf is taped on the ceiling above the bookshelf.

## Interaction
- Look at object + press E (prompt appears, e.g. "Press E to turn on lamp").

## Automatic events (3)
1. Entering the study: door creaks shut, room is dark.
2. Walking up to the whiteboard (after the music): realization thought, stress drops.
3. 90 seconds after entering the study: phone buzz from book club ("Where are you??"), stress +10%.

## Stress values
| Moment | Stress |
|---|---|
| Start | 60% |
| Book missing | 100% |
| Note read | 80% |
| Lamp on | 70% |
| D'yer Mak'er | 50% |
| Whiteboard realization | 35% |
| Find Philosophical Investigations | 20% |
| Steppenwolf | 0% |
| Phone buzz | +10% |

## Meaningful object thoughts (shown when stress drops)
- Lamp: "Grandpa's old library lamp. I've read every book I love under this light."
- D'yer Mak'er: "Zeppelin... this song always slows my heart down."
- Whiteboard: "My whiteboard! It's untangled so many of my thoughts. Of course she wrote it here."
- Philosophical Investigations: "The book that changed how I think about language. Wittgenstein, you're on my side today."
- Steppenwolf: "There you are, old friend. Sorry, sis, not today."

## Hallway sequence
- E on the bag: thoughts play in order: "Hm, lighter than expected..." -> "The book's gone!" (stress 100%) -> "Wait, what's this?"
- The note opens on screen. Closing it: stress 80%.
- The study door unlocks only after the note has been read.

## Note "inventory"
- No full inventory screen. Press N at any time to reopen the note.
- A small note icon in a screen corner shows the player has it.

## The note (sister's voice)
Looking for something, nerd? 😜

Your precious book is hiding somewhere in your study. I even left you a riddle, because I'm SO nice.

Can't figure it out? Just look it up.   <- "Just look it up" underlined

Good luck with your little book club. You'll need it.

— Your favorite sister

## Study sequence
1. Lamp: the only interactable object in the dark.
2. Radio: works after the lamp. First E = on (static); each E cycles static -> news talk -> pop -> D'yer Mak'er -> static. Stress drops after ~3 seconds of D'yer Mak'er.
3. Whiteboard: before the music, thought "I'm too stressed to think straight... maybe some music would help." After the music, the realization event fires and shows the riddle "Maybe if you drop it? -LW".
4. Bookshelf: only after reading the riddle. E opens a menu of book titles; only Philosophical Investigations is correct.
5. Riddle answer menu: A (The whole game and give up) / B (The note) / C (The word "it"). C is correct, and the player looks up to find Steppenwolf.

## Wrong answers (book menu and riddle)
- Thought "No, that doesn't make sense", menu stays open, stress unchanged.

## Ending
- When Steppenwolf is found (stress 0): fade to an end screen.

## Still to design
- Ambient sound
- GUI: start menu and exit
