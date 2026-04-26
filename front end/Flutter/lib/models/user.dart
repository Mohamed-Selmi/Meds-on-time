class User {
  final int Id;
  final String Email;
  final String FirstName;
  final String LastName;
  final String? Gender;
  final DateTime DateOfBirth;
  User({
    required this.Id,
    required this.Email,
    required this.FirstName,
    required this.LastName,
    required this.DateOfBirth,
    this.Gender
});
  factory User.fromJson(Map<String,dynamic> json){
    return User(
      Id: json['id'],
      Email: json['Email'],
      FirstName: json['FirstName'],
      LastName: json['LastName'],
      DateOfBirth: json['DateOfBirth'],
      Gender: json['Gender'],
    );
  }
  Map<String, dynamic> toJson(){
    return{
      'Email': Email,
      'FirstName': FirstName,
      'LastName': LastName,
      'DateOfBirth': DateOfBirth,
      'Gender': Gender,
    };
  }
}