class User {
  final int id;
  final String email;
  final String firstName;
  final String lastName;
  final String? gender;
  final DateTime dateOfBirth;
  User({
    required this.id,
    required this.email,
    required this.firstName,
    required this.lastName,
    required this.dateOfBirth,
    this.gender
});
}