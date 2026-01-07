# Repository Guidelines

## Project Structure & Module Organization
- `cv_mateus_linkedin.html`: primary CV page with inline CSS and all content in Portuguese (pt-BR).
- `Curriculo Mateus Inocentini..docx` and `Mateus.Inocentini_CV.docx` (plus `.odt` export): source documents for the CV; keep them in the root for easy reference.
- Add new assets (images, PDFs) under a new `assets/` folder to keep the root clean.

## Build, Preview, and Development Commands
- No build system is needed; the HTML is self-contained. Open the file directly in a browser or run `python -m http.server 8000` and visit `http://localhost:8000/cv_mateus_linkedin.html` for a local preview.
- When editing, keep the inline `<style>` block minimal; avoid external CDNs to preserve offline viewing.

## Coding Style & Naming Conventions
- HTML indentation uses 4 spaces; keep the existing heading hierarchy (`h1` → `h2` → `h3`) and section wrappers (`.section`) for readability and consistent spacing.
- Reuse existing CSS classes like `.tag-list` and `.job-meta` instead of adding near-duplicates; group new rules near related ones in the `<style>` block.
- Maintain Portuguese copy and locale attributes (`lang="pt-BR"`). Keep file names descriptive and lowercase with underscores (e.g., `cv_mateus_linkedin.html`, `assets/profile.jpg`).

## Testing and QA
- Manually verify the page in both desktop and mobile widths; check that contact links (`mailto`, `tel`, external profiles) open correctly.
- Optional: run `tidy -errors cv_mateus_linkedin.html` to catch malformed HTML; fix reported issues before sharing.
- If editing the DOCX/ODT sources, export a new HTML and re-check spacing, lists, and accented characters for encoding issues.

## Commit and Pull Request Guidelines
- If you use Git, write imperative, concise commit messages (e.g., `Adjust contact links`, `Refine experience bullets`); keep the summary ≤50 characters and add details in the body when needed.
- For PRs, include a brief description of the change, mention any new assets added to `assets/`, and attach a before/after screenshot of the CV if the layout changes.
