// @ts-check
import { test, expect } from '@playwright/test';

const LOCALHOST_URL = 'http://localhost:5173/'

test('app Shows a random fact and img  ', async ({ page }) => {
  await page.goto(LOCALHOST_URL);

  // Expect a title "to contain" a substring.
  const text = page.getByTestId('fact')
  const img = page.getByTestId('fact-img')

  const textContent = await text.textContent()
  const imgSource = await img.getAttribute('src')

  await expect(textContent?.length).toBeGreaterThan(0)
  await expect(imgSource).toBeTruthy()
});


