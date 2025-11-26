# PR Review Feedback

## File Reviewed
- [x] `CodeToReview.cs`

## General Comments
- This pull request contains multiple critical issues that prevents the code from functioning properly. 
- A few recommended fixes are found for better conventional and readable code.
- The code requires a few changes before it can be merged. 
- 17 issues are found, including 8 critical issues, 3 code quality issues, 4 naming issues and 2 comment issues.

## Required Changes

**Critical Issues**
- Line 2: There is a spelling error for "Collections" in namespace.
- Line 37: Wrong instance used in the looping method.
- Line 39-58: List _people should be cleared everytime after the operation is finished.
- Line 44: Random number generation only gives 0, which makes the function never add "Betty".
- Line 51: 356 is not the correct number of days in a year.
- Line 64: Current method returns people younger than 30 instead of older with ">=", 356 is not the correct number of days in a year.
- Line 71: Wrong variable used to caluclate length.
- Line 73: Missing return statement.

**Code Quality Issues**
- Line 13: Inconsistent type name for DateTimeOffset.
- Line 39-58: Try-catch is not necessary since the operation is unlikely to fail. 
- Line 62-65: Method GetBobs is never used internally.

**Naming Issues**
- Line 7: Class name "People" is plural which doesn't serve the purpose of the class for a single person.
- Line 9: "Under16" is a confusing constant name and it doesn't describe the purpose clearly.
- Line 16: "BirthingUnit" is a confusing class name and it doesn't describe the purpose clearly.
- Line 35: "i" is not a descriptive parameter name.

**Documentation Issues**
- Line 30-34: Wrong parameter name and return type are recorded.
- Line 42: There is a spelling error for "random".

---

**Reviewed by:** Violet Chen (@vi0letchen)
**Date:** 25/11/2025
**Status:** Request Changes