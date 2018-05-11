# Portfolio

### By Andy Grossberg

## Description
A .Net portfolio with blog and user comments as well as a Projects page with the top three most starred Github repos.

## Rules

This is a personal portfolio site. I'll be building this same project for the next two Fridays.

The site must include:

* A landing page featuring an image of yourself or an image that expresses your style.
* A blog section featuring your posts. You are not required to write any posts for this project.

* Users should be able to:
  - comment on specific blog posts I’ve made.
  - see all previous comments left on blog posts. (All comments should have body and author fields)

* I should be able to log on/off as an administrator for my portfolio.
  - I can choose to either seed my database with an admin username and password, or include a registration page to register.

* At the admin level I should be able to:
  - Create, Read, Update, and Delete blog entries.
    * (I will Use AJAX for the GET methods for this)
  - Create comments and view and remove comments anywhere on the site.

* My site must include:
    - My work experience
    - My relevant skills
    - My education
    - How I got into coding
    - A personal story and interests
    - Contact information (link to GH, linkedin)
    - My Your personal and work projects

## Objectives

**Phase One Objectives**
* Code continues to meet all of the standards from last week.

* Application works as expected.

* Application uses Identity properly. Requested login/logoff functionality is present.

* Application uses AJAX successfully. Requested AJAX functionality is present and working.

* Code is clear, easy to understand, and well-refactored.

* Project is in a polished, portfolio-quality state.

* Required functionality was present by Friday deadline.

* Project demonstrate understanding of this week's concepts. If prompted, you can discuss your code with an instructor using correct terminology.

**Phase Two Objectives**

* Build out projects section

* Add Github API connection

* Display top three most-starred apps on Github

* Return to correct and finish incomplete or malfunctioning Phase One Objectives

## User Stories
There will ultimately be two levels of user for this site: Administrator and Reader. At the start however every user is an Admin.

**All Users**
* Read Blog Posts

* Comment on Blog Posts

**Admin**
* Create, Read, Update and Delete posts and Comments

* Maybe Remove or Block users

## Specifications

* Blog Data Model is created. -- X

* User Data Model is created. -- X

* Comment Data Model is created. -- X

* Add Author name to Comments

* ??? Add DateTime to BlogPosts

* Migrate database to update BlogPosts and Comments

* Site MVC Built.
  - Home Controller
  - Home View
  - Login/Register Controller
  - Login/ Register View
  - Blog Controller
  - Blog View

* Landing page created (updated from Home View). -- X

* Landing page features an image that expresses my style. -- X

* Blog database migration -- X

* Authentication via Nav bar -- !!!

* Fix Authorization!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

* LOGOUT USING AJAX <---------------------------------------------------------

* Blog Entries can be READ

* Blog Entries can be created, retrieved, updated, and removed from the database.

* ?Users can be created, retrieved, updated, and removed from the database.

* Blog Entry Comments can be read 

* Blog Entry Comments can be added by Users.

* Blog Entry Comments can be CREATED, READ, UPDATED, and DELETED by Admin


* Make API call to github

* Parse JSON results into StarredProject object

* Display Results on Projects page


* User Authorization Levels

* Only Admin can post blog posts

* Style and personalize site.

* Refactor code as needed.

## Methodology and Comments

Last week we studied Authentication and AJAX and so I'm using those class projects as inspiration for the back end of the app. The last two-week project had reviews and those are the same as comments so I will use something similar in structure.

This week I have completely changed how I am going to do my blog posts and comments. I will complete this after I complete the API call.

## Technologies Used

* HTML
* CSS
* Javascript
* jQuery
* C#
* .NET (ASP) Core
* mySQL

## Dependencies and plugins

**Dependencies**
TBD

## Setup/Installation Requirements
TBD

## Future expansion
There is room to separate the Admin from Users but not in the short term. In order to keep updating this site I will have to do so.

## Known Bugs and Issues

There are no known bugs or issues at this time.

## Support and contact details

@using (Html.BeginForm("LogOff", "Account"))
    {
        <input type="submit" class="btn btn-default" value="Log out" />
    }

**Contact the author at andy.grossberg@gmail.com**

## License
Licensed for use under the GNU GPL. (c) 2018 Andy Grossberg
