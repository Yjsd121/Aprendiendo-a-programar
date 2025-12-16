// @ts-check
import { test, expect } from '@playwright/test';

const LOCALHOST_URL = 'http://localhost:5173/'

test('app Shows a random fact and img  ', async ({ page }) => {
  await page.goto('https://playwright.dev/');

  // Expect a title "to contain" a substring.
  const text = await page.getByRole('paragraph')
  const img = await page.getByRole('img')

  const textContent = await text.textContent()
  const ImgSorce = await img.getAttribute('src')

  await expect(textContent?.length).toBeGreaterThan(0)
  await expect( ImgSorce).toBeTruthy()
});


