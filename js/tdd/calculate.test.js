// Arrange
const calculate = require('./calculate');
// Act/Assert
test('adds 1 + 2 to equal 3', () => {
  expect(calculate(1, 2)).toBe(3);
});