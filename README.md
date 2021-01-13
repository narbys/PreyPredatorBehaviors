# Prey and Predator Behaviors
This project looks at the behaviors of animals related to hunting prey or fleeing from predators. Whereafter they could be put into an Artificial Intelligence to simulate these behaviors.

# Animals and senses
Animals have many ways to perceive the world, some more straightforward than others. One of these most important factors is their vision, more specifically related to this topic: their Field of View. Predators typically have front facing eyes, where the vision of each individual eye overlaps more. The overlapping part results in depth perception. This depth perception is highly useful in hunting prey. The prey themselves on the other hand have eyes on the side, so they have a very wide view range. This allows them to see predators coming from all sides making it easier to flee on time. The predator's type of vision is called Binocular vision, the prey's kind is called Monocular vision. 

![Image of comparison between predator and prey field of view](https://cdn.discordapp.com/attachments/648302031404269588/798980169447637052/unknown.png)

Except for vision animals also have other senses. This of course can differ wildy depending on which animal you're looking at, so in this project we're going to look at some specific animals.

# The Rabbit and the Fox
The specific animals we're looking at at first will be the Red Fox (Vulpes Vulpes) and the European Rabbit (Oryctolagus cuniculus). These are chosen because they are common animals that live in the same environments. They are both also more alone than in group.   

#### Fox senses
Let's start with taking a look at our predator, the fox. Foxes have a total FOV of 200 degrees, except for that their eyes are also more sensitive to light giving them nightvision. On top of that they also have very good hearing, they can rotate their ears independently to pick up sound sources from all sides. Because foxes are a subfamily of Canidae (the dog family), it goes without saying that they also have a great sense of smell.
#### Fox hunting
Because of their nightvision, most of the time foxes hunt at night or in the evening. However, in undisturbed areas they prefer to hunt during the day. Foxes are omnivorous and opportunist hunters. They eat almost everything, most of the time rodents like mice and rabbits or birds. They don't eat frogs however and also don't like moles.

When the fox has spotted a prey with one of their senses, they will first try to stealthily sneak up on them. After which it will calculate the position of it's prey and jump on top of them. You might recognise this from videos of foxes jumping headfirst into snow, which perfectly displays the strength of their senses'ability to spot prey. If they miss their prey, they can still chase it with their running speed of 50km/h.

#### Rabbit senses
On the other end, we have the fox's prey: the rabbit. As most people already know, rabbits have big ears so they can receive sounds better. They also, just like with the fox, can turn their ears independently to pick up sounds from all sides. Rabbits have a much larger FOV than foxes, they are able to see almost 360 degrees around them. As explained before, this comes at the cost of having less depth perception. Rabbits have blind spots behind them and right in front of their noses because of the location of their eyes too, but this is not much of an issue. They also have an excellent sense of smell, being able to smell nearby predators.
#### Rabbit fleeing
When a rabbit notices a predator trying to attack them, they will try to flee to a safe underground location. Rabbits have a running speed of 40km/h, they will try to flee this way. Running away fast is not the only thing they are capable of however. They can change direction almost instantly, making it hard for the predator to keep up with them.

# Implementation
Of course, the goal of this is to put these behaviors into an AI. For this part, I chose to use the Unity Engine since it seemed the easiest to use for the purposes of this project.

As of now, I don't stand very far with my implementation. The rabbit runs from the fox and both wander around, but that's about it. The content of this may or may not improve in the future.

### Sources
> https://northamericannature.com/how-do-foxes-navigate/ - Article about foxes

> https://www.youtube.com/watch?v=gGludGaPKag - BBC Earth

> https://en.wikipedia.org/wiki/European_rabbit - Wikipedia: European Rabbit

> https://en.wikipedia.org/wiki/Red_fox - Wikipedia: Red Fox

> https://animals.mom.com/five-senses-rabbits-depend-most-10900.html - Forum post about rabbit senses

> https://www.youtube.com/watch?v=rQG9aUWarwE	- Unity tutorial on FOV

