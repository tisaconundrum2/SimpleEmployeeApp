/*
 * Generally, it is good Practice to setup a ViewModel 
 * that encapsulates a portion of your true Model.
 * In this way, you prevent the possibility of any of
 * your vulnerable data from escaping to the frontend
 * Someone clever enough can utilize a GET method to 
 * force the App to spit out data you don't intend to 
 * be showing to a user.
 * 
 * A ViewModel prevents that from happening. For this 
 * particular situation I'm opting to not utilize a 
 * fill ViewModel as it will just be redundant code
 * And the Employee Model has nothing that I don't
 * want to share already.
 * 
 * In the future, there could be a situation where I
 * don't want the Social Security Number to viewable
 * So I can prevent that from being seen by using the
 * ViewModel. 
 */