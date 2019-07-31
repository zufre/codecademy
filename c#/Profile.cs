using System;

namespace DatingProfile
{ 
  class Profile {
     private string name;
    private int age;
    private string city;
    private string country;
    private string pronouns;
  	private string[] hobbies;
    
    public Profile(string name, int age, string city, string country, string pronouns="they/them"){
      this.name = name;
      this.age = age;
      this.city = city;
      this.country= country;
      this.pronouns = pronouns;
      
    }
  	public string ViewProfile(){

    
    return $"Name: {name}\nAge: {age}\nCity: {city}\nCountry: {country}\nPronouns: {pronouns}\nHobbies: {hobbies}" ;
  }
    public void SetHobbies(string[] hobbies) {
      this.hobbies = hobbies;
    }
  }
}
