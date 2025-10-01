const yesCheckbox = document.getElementById("inlineCheckboxYes");
const noCheckbox = document.getElementById("inlineCheckboxNo");
const detailsBox = document.getElementById("childrenDetails");

yesCheckbox.addEventListener("change", function () {
    if (this.checked) {
        noCheckbox.checked = false;
        detailsBox.style.display = "block"; // Show textarea
    } else {
        detailsBox.style.display = "none"; // Hide if unchecked
    }
});

noCheckbox.addEventListener("change", function () {
    if (this.checked) {
        yesCheckbox.checked = false;
        detailsBox.style.display = "none"; // Hide textarea
    }
});