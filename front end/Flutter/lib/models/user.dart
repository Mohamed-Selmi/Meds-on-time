class User {
  final int? Id;
  final String email;
  final String firstName;
  final String lastName;
  final String? gender;
  final String dateOfBirth;
  User({
    required this.Id,
    required this.email,
    required this.firstName,
    required this.lastName,
    required this.dateOfBirth,
    this.gender
});
  factory User.fromJson(Map<String,dynamic> json){
    return User(
      Id: json['id'],
      email: json['email'],
      firstName: json['firstName'],
      lastName: json['lastName'],
      dateOfBirth: json['dateOfBirth'],
      gender: json['gender'],
    );
  }
  Map<String, dynamic> toJson(){
    return{
      'email': email,
      'firstName': firstName,
      'lastName': lastName,
      'dateOfBirth': dateOfBirth,
      'gender': gender,
    };
  }
}