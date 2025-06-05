Feature: StudentRegistration

A short summary of the feature
Background:
  Given User is on the student registration page
 
@Regression,@Functional
Scenario: Verify Student Registration with valid credentails
  When User enters the Name "Akash"
  And User enters the Email "akash@gmail.com"
  And User selects the Gender "Male"
  And User enters the Mobile "797483683"
  And User enters the Date of Birth "2003-02-15"
  And User enters the Subjects "Maths"
  And User selects the Hobbies "Sports, Music"
  And User enters the Current Address "abcd"
  And User selects the State "Uttar Pradesh"
  And User selects the City "Lucknow"
  Then The form is submitted successfully
