document.querySelector(".php-email-form").addEventListener("submit", function(e) {
  e.preventDefault();

  let form = this;
  let submitBtn = form.querySelector(".btn-submit");

  // Show spinner on button
  submitBtn.innerHTML = `<span class="spinner-border spinner-border-sm" role="status" aria-hidden="true"></span> Sending...`;
  submitBtn.disabled = true;

  // Send form via AJAX
  fetch(form.action, {
    method: "POST",
    body: new FormData(form)
  })
  .then(response => response.json()) // expect JSON response
  .then(data => {
    if (data.success) {
      Swal.fire("Success!", "Your message was sent successfully.", "success");
      form.reset();
    } else {
      Swal.fire("Error", "Failed to send message. Try again later.", "error");
    }
  })
  .catch(() => {
    Swal.fire("Error", "Something went wrong. Please try again.", "error");
  })
  .finally(() => {
    submitBtn.innerHTML = "SEND MESSAGE";
    submitBtn.disabled = false;
  });
});