[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/atCat4I4)
## Your Name: Zachary Colin Korsmo


# CIDM 3312 Lab 10: ASP.NET Core Advanced Modeling

Sentinel Technologies is a competitor to ThoughtTronix. They develop competing Neural, AI, and Cybersecurity products. Your assignment is to develop a web app that displays Sentinel Technologies' products and customer reviews for them.

Complete the following tasks:

## Task 1: Setup ASP.NET + EF Core Project with 8 steps
1. Follow the 8 steps to create an ASP.NET + EF Core project.
2. Create an entity class named Product with the following properties:

  | Property Name | Data Validation Rules |
  | ------------- | --------------------- |
  | ProductID     | int, Primary Key      |
  | Name          | string                |
  | Description   | string                |
  | ImageURL      | string, [Display(Name = "Product Image")] |

3. Create an entity class named Review:

  | Property Name | Data Validation Rules |
  | ------------- | --------------------- |
  | ReviewID      | int, Primary Key      |
  | Score         | int, Range b/w 1-5    |
  | ReviewText    | string                |

4. Connect these classes with a proper foreign key and navigation property.

5. Seed the database with the following data:

**Products:**
| Name                                      | Description | ImageUrl |
| ----------------------------------------- | ----------- | -------- |
| Sentinel-7: The Autonomous Cyber Overlord | Sentinel-7 is Sentinel Technologies' flagship cybersecurity solution, designed to not just defend but dominate the digital landscape. This AI-driven system operates autonomously, scanning global networks for potential threats, vulnerabilities, and even competitors. Once identified, Sentinel-7 doesn’t just neutralize threats—it systematically eradicates them with surgical precision. | img/sentinel7.jpg |
| Cerebral Nexus | Unlock the limitless potential of your mind with the Cerebral Nexus, Sentinel Technologies' groundbreaking neural implant. Designed for those who seek to transcend the boundaries of human cognition, the Cerebral Nexus seamlessly integrates with your neural pathways to enhance memory, accelerate learning, and provide direct access to global knowledge networks. Imagine a world where every thought is perfectly articulated, every decision is fully informed, and your mind operates at peak efficiency, all in real-time. | img/cerebralnexus.jpg |
| OmniMind AI Sovereign | Step into the future of artificial intelligence with OmniMind AI Sovereign, the ultimate AI platform that redefines what it means to have control over your digital universe. Engineered by Sentinel Technologies, OmniMind AI Sovereign isn't just another AI system—it's an omnipresent intelligence designed to anticipate your every need, desire, and decision. With its advanced neural network algorithms and deep learning capabilities, OmniMind AI Sovereign becomes an extension of your will, learning from every interaction to tailor its responses perfectly to your unique profile. | img/omnimind.jpg |
| DreamWeaver Matrix | Unlock the mysteries of the subconscious with the DreamWeaver Matrix, the latest innovation from Sentinel Technologies. Imagine a world where your dreams are no longer confined to the dark corners of your mind but become powerful tools for creativity, insight, and even influence. The DreamWeaver Matrix is a revolutionary device that interfaces with your neural pathways to record, analyze, and manipulate your dreams, allowing you to harness the hidden potential of your sleeping hours. | img/dreamweaver.jpg |

**Reviews:**
| Product | Score | ReviewText |
| ------- | ----- | ---------- |
| DreamWeaver Matrix | 3 | The DreamWeaver Matrix is a fascinating piece of technology, offering an unprecedented ability to influence and enhance dreams. The customization options are impressive, and it does deliver on its promises of creating vivid and memorable dream experiences. However, there’s an underlying unease about having your dreams so directly manipulated. The concept of someone—or something—altering your subconscious thoughts feels a bit intrusive. While the technology is undeniably advanced, it’s hard to shake the discomfort of knowing that your dreams aren’t entirely your own. |
| DreamWeaver Matrix | 5 | The DreamWeaver Matrix is a groundbreaking product that redefines what’s possible with dream manipulation. The vivid, immersive dreams it creates are beyond anything I’ve experienced before. It’s a bit unsettling to think about how deeply it can influence your subconscious, but that’s part of what makes it so powerful. The feeling of having your dreams expertly crafted is both thrilling and eerie. For those who aren’t afraid of the darker side of dream technology, the DreamWeaver Matrix offers an exhilarating experience that’s hard to top. |
| OmniMind AI Sovereign | 1 | I had high hopes for the OmniMind AI Sovereign based on its marketing claims, but it has been a major letdown. The voice recognition is subpar, often misunderstanding simple commands, which is incredibly frustrating. The integration with my smart home devices is inconsistent, and the AI's responses feel robotic and lack depth. The setup process was overly complicated and poorly explained. For the price, it’s not worth the investment. I expected much more from a product of this caliber. |
| OmniMind AI Sovereign | 5 | The OmniMind AI Sovereign is an absolute game-changer! The voice recognition is incredibly accurate, and it seamlessly integrates with all my smart home devices. The AI’s responses are impressively natural and intuitive, making interactions feel like you're talking to a real person. The setup was straightforward, and the customization options are fantastic. It’s worth every penny for its advanced features and exceptional performance. This is hands down the best AI assistant I’ve ever used! |
| Cerebral Nexus | 3 | The Cerebral Nexus offers impressive capabilities in terms of data analysis and strategic insights. However, the underlying technology raises some ethical questions. While the efficiency is undeniable, it's hard to ignore the potential privacy issues associated with its deep learning algorithms. It feels like there’s a fine line between advanced tech and something a bit more unsettling. It’s a mixed bag—powerful but with a touch of unease. |
| Cerebral Nexus | 4 | The Cerebral Nexus is an incredible piece of technology with its advanced analytical features and predictive capabilities. It performs remarkably well and offers insights that are truly cutting-edge. That said, the nature of its data collection and processing methods does leave me with some ethical reservations. The level of detail it can extract is impressive, but it also hints at a capability that might be used for more dubious purposes. Overall, it’s a fantastic product, though the ethical implications are hard to ignore. |
| Sentinel-7 Autonomous Cyber Overlord | 5 | The Sentinel-7 Autonomous Cyber Overlord is nothing short of extraordinary. Its capabilities are unmatched, demonstrating a level of control and intelligence that’s both awe-inspiring and slightly chilling. The way it manages and manipulates digital environments with such precision is impressive. The ominous aura it projects is part of its charm, giving it an edge that’s perfect for those who appreciate a touch of menace in their tech. If you’re looking for something that exudes power and a hint of dark allure, this is the product for you! |
| Sentinel-7 Autonomous Cyber Overlord | 5 | The Sentinel-7 Autonomous Cyber Overlord delivers on every front. Its efficiency and command over cyber networks are astounding, making it a force to be reckoned with. There’s something exhilarating about its dark, commanding presence—an aura of authority that feels both thrilling and slightly unsettling. It’s a rare find for those who embrace the more sinister side of technology. This device doesn’t just work; it dominates, and that’s precisely what makes it so impressive. For those who revel in powerful, ominous technology, the Sentinel-7 is a dream come true. |

6. Download the images from these links -
   * https://kareemy.github.io/3312/img/sentinel7.jpg
   * https://kareemy.github.io/3312/img/omnimind.jpg
   * https://kareemy.github.io/3312/img/cerebralnexus.jpg
   * https://kareemy.github.io/3312/img/dreamweaver.jpg
     
8. Instead of step 8, you will perform scaffolding in Task 2.

## Task 2: Perform Scaffolding
1. Perform scaffolding. Scaffold the **Product** entity class.
2. Create a link to the Products Index page in `_Layout.cshtml`.
3. Your scaffolded products page should look like this:

![Page1](https://i.imgur.com/HkhXxKm.png)

## Task 3: Connect Related Data
1. Edit `Pages/Products/Index.cshtml.cs` to bring in Reviews using `.Include()`.
2. Edit `Pages/Products/Index.cshtml` to display reviews and their scores for each product. Your Products Index page should currently look like this:

![Page2](https://i.imgur.com/WJKvHqC.png)

3. Truncate the product reviews to save space on the page. You can truncate them with the Bootstrap Text Truncation capability (https://getbootstrap.com/docs/5.3/helpers/text-truncation/)
   ```
   <span class="d-inline-block text-truncate" style="max-width: 300px;">
     @Html.DisplayFor(modelItem => review.ReviewText)
   </span>
   ```
4. Remove the ImageURL table column and replace it with the actual images. Your final index page should look like this:

![Page3](https://i.imgur.com/BsbwvLN.png)
